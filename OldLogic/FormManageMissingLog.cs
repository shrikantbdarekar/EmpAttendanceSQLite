using EmpAttendanceSQLite.Data;
using EmpAttendanceSQLite.Models;
using System.Diagnostics.SymbolStore;
using System.Windows.Forms;

namespace EmpAttendanceSQLite
{
    public partial class FormManageMissingLog : Form
    {
        public FormManageMissingLog()
        {
            InitializeComponent();

            dataGridViewMissingLogs.AutoGenerateColumns = false;
            dataGridViewImportedLogs.AutoGenerateColumns = false;
            dataGridViewGroupByEmployee.AutoGenerateColumns = false;
        }

        private void FormImportAttendanceLog_Load(object sender, EventArgs e)
        {
            // Visible for super admin only
            if (Program.loginUser.Role == (int)UserRoles.SuperAdmin)
            {
                dgcMissingBatchCode.Visible = true;
                dgcBatchCode.Visible = true;
            }

            LoadBatchCode();
        }

        private void LoadBatchCode()
        {
            using (var context = new AppDbContext())
            {
                var batchCodes = context.MissingLogs
                    .Select(x => new { BatchCode = x.BatchCode })
                    .Distinct()
                    .ToList();

                comboBoxBatchCode.DataSource = batchCodes;
                comboBoxBatchCode.DisplayMember = "BatchCode"; // Display in dropdown
                comboBoxBatchCode.ValueMember = "BatchCode";   // Stored value
            }
        }

        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            LoadGridviewData();
        }

        private void LoadGridviewData()
        {
            using (var context = new AppDbContext())
            {
                if (comboBoxBatchCode.SelectedValue != null)
                {
                    var missingLogData = (from ml in context.MissingLogs
                                          join emp in context.Employees on ml.BMEmployeeId equals emp.BMEmployeeId
                                          select new
                                          {
                                              ml.MissingLogId,
                                              ml.BMEmployeeId,
                                              EmployeeName = emp.EmployeeName,
                                              EmployeeId = emp.EmployeeId,
                                              ml.PunchDate,
                                              ml.MissingType,
                                              ml.CreatedAt,
                                              ml.BatchCode
                                          }).ToList();

                    dataGridViewMissingLogs.DataSource = missingLogData;


                    var biometricLogData = (from bl in context.BiometricLogs
                                            join emp in context.Employees on bl.BMEmployeeId equals emp.BMEmployeeId
                                            orderby bl.PunchTime, bl.BMEmployeeId // Sorting first by PunchTime, then BMEmployeeId
                                            select new
                                            {
                                                bl.LogId,
                                                bl.BMEmployeeId,
                                                EmployeeName = emp.EmployeeName,
                                                EmployeeId = emp.EmployeeId,
                                                bl.PunchTime,
                                                bl.DeviceId,
                                                bl.PunchTypeFlag,
                                                bl.VerificationMode,
                                                bl.StatusCode,
                                                bl.CreatedAt,
                                                bl.RecordType,
                                                bl.BatchCode
                                            }).ToList();

                    dataGridViewImportedLogs.DataSource = biometricLogData;

                    //dataGridViewImportedLogs.DataSource = context.BiometricLogs
                    //    .Where(x => x.BatchCode == comboBoxBatchCode.SelectedValue)
                    //    .ToList();

                    //dataGridViewMissingLogs.DataSource = context.MissingLogs
                    //    .Where(x => x.BatchCode == comboBoxBatchCode.SelectedValue)
                    //    .ToList();


                    var biometricLogDataEmployeeGroup = context.BiometricLogs
                        .Join(context.Employees,
                              bl => bl.BMEmployeeId,
                              emp => emp.BMEmployeeId,
                              (bl, emp) => new
                              {
                                  bl.LogId,
                                  bl.BMEmployeeId,
                                  EmployeeName = emp.EmployeeName,
                                  EmployeeId = emp.EmployeeId,
                                  bl.PunchTime,
                                  bl.DeviceId,
                                  bl.PunchTypeFlag,
                                  bl.VerificationMode,
                                  bl.StatusCode,
                                  bl.CreatedAt,
                                  bl.RecordType,
                                  bl.BatchCode
                              })
                        .ToList()
                        .GroupBy(x => x.BMEmployeeId) // Group by BMEmployeeId
                        .Select(g => g.OrderBy(x => x.PunchTime)) // Order within each group by PunchTime
                        .SelectMany(g => g) // Flatten grouped results into a single list
                        .ToList();

                    //var biometricLogDataEmployeeGroup = (from bl in context.BiometricLogs
                    //                        join emp in context.Employees on bl.BMEmployeeId equals emp.BMEmployeeId
                    //                        select new
                    //                        {
                    //                            bl.LogId,
                    //                            bl.BMEmployeeId,
                    //                            EmployeeName = emp.EmployeeName,
                    //                            EmployeeId = emp.EmployeeId,
                    //                            bl.PunchTime,
                    //                            bl.DeviceId,
                    //                            bl.PunchTypeFlag,
                    //                            bl.VerificationMode,
                    //                            bl.StatusCode,
                    //                            bl.CreatedAt,
                    //                            bl.RecordType,
                    //                            bl.BatchCode
                    //                        })
                    //    .GroupBy(x => x.BMEmployeeId)
                    //    .SelectMany(g => g.OrderBy(x => x.PunchTime))
                    //    .ToList();

                    dataGridViewGroupByEmployee.DataSource = biometricLogDataEmployeeGroup;
                }
                else
                {
                    MessageBox.Show("Select Batch Code!", "Batch Code");
                    comboBoxBatchCode.Focus();
                }
            }

            tabPageMissingLogs.Text = "#Missing Logs " + dataGridViewMissingLogs.RowCount + "     ";
            tabPageImportedLog.Text = "#Imported Logs " + dataGridViewImportedLogs.RowCount + "     ";

            Application.DoEvents();
        }
        private void buttonDeleteBatchData_Click(object sender, EventArgs e)
        {
            if (dataGridViewImportedLogs.RowCount <= 0)
            {
                MessageBox.Show("Load Batch to delete data!");
                return;
            }

            if (MessageBox.Show("Do you want to delete complete log data for selected Batch?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            using (var context = new AppDbContext())
            {
                if (comboBoxBatchCode.SelectedValue != null)
                {
                    var batchCode = comboBoxBatchCode.SelectedValue;

                    // Delete from MissingLogs
                    var missingLogs = context.MissingLogs.Where(x => x.BatchCode == batchCode).ToList();
                    context.MissingLogs.RemoveRange(missingLogs);

                    // Delete from BiometricLogs
                    var biometricLogs = context.BiometricLogs.Where(x => x.BatchCode == batchCode).ToList();
                    context.BiometricLogs.RemoveRange(biometricLogs);

                    context.SaveChanges();

                    MessageBox.Show("Batch data deleted successfully!", "Process Complete");
                    comboBoxBatchCode.Focus();

                    LoadBatchCode();
                }
                else
                {
                    MessageBox.Show("Select Batch Code!", "Batch Code");
                    comboBoxBatchCode.Focus();
                }
            }

        }

        private void dataGridViewMissingLogs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgcMissingAddLog.Index)
            {
                using (var context = new AppDbContext())
                {
                    var employee = context.Employees.Find(dataGridViewMissingLogs.CurrentRow.Cells[dgcMissingEmployeeId.Name].Value);
                    var missingLog = context.MissingLogs.Find(dataGridViewMissingLogs.CurrentRow.Cells[dgcMissingLogId.Name].Value);

                    if (employee == null || missingLog == null)
                    {
                        MessageBox.Show("Employee data or missing log data missing!");
                        return;
                    }

                    // Show form to read values
                    FormAddManualLog formAddManualLog = new FormAddManualLog(employee, missingLog);
                    formAddManualLog.ShowDialog();

                    // Reload grid missing logs
                    // Reload grid imported logs
                    LoadGridviewData();
                }
            }
        }

        private void dataGridViewImportedLogs_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // Ensure the row index is valid
            if (e.RowIndex >= 0)
            {
                // Get the RecordType value from the DataGridView
                var row = dataGridViewImportedLogs.Rows[e.RowIndex];
                var recordType = row.Cells[dgcRecordType.Name].Value?.ToString(); // Ensure column name is correct

                // Check if the record type is "MANL"
                if (recordType == "MANL")
                {
                    row.DefaultCellStyle.ForeColor = Color.Black; // Change text color to red
                    row.DefaultCellStyle.BackColor = Color.Silver; // Change text color to red
                }
            }
        }
    }
}
