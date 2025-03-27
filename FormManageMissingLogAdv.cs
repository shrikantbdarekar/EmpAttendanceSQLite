using EmpAttendanceSQLite.Data;
using EmpAttendanceSQLite.Models;
using System.Diagnostics.SymbolStore;
using System.Windows.Forms;

namespace EmpAttendanceSQLite
{
    public partial class FormManageMissingLogAdv : Form
    {
        public FormManageMissingLogAdv()
        {
            InitializeComponent();

            dataGridViewBiometricLogs.AutoGenerateColumns = false;
            dataGridViewOneEntry.AutoGenerateColumns = false;
            dataGridViewTwoPlusEntry.AutoGenerateColumns = false;
        }

        private void FormImportAttendanceLog_Load(object sender, EventArgs e)
        {
            // Visible for super admin only
            if (Program.loginUser.Role == (int)UserRoles.SuperAdmin)
            {
                dgcBatchCode.Visible = true;
                dgcOneEntryBatchCode.Visible = true;
                dgcTwoPlusEntryBatchCode.Visible = true;

                buttonDeleteLog.Visible = true;
            }

            LoadBatchCode();
        }

        private void LoadBatchCode()
        {
            using (var context = new AppDbContext())
            {
                var batchCodes = context.BiometricLogs
                    .Where(x => x.InOut == "NA") // Filter condition applied here
                    .Select(x => new
                    {
                        BatchCode = x.BatchCode,
                        DisplayBatchName = x.BatchCode + " # " + x.StartDate.ToString("dd/MM/yyyy") + " to " + x.EndDate.ToString("dd/MM/yyyy")
                    })
                    .Distinct()
                    .ToList();

                comboBoxBatchCode.DataSource = batchCodes;
                comboBoxBatchCode.DisplayMember = "DisplayBatchName"; // Display in dropdown
                comboBoxBatchCode.ValueMember = "BatchCode";   // Stored value
            }
        }

        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            LoadGridviewData();

            if (dataGridViewOneEntry.RowCount == 0 && dataGridViewTwoPlusEntry.RowCount == 0)
                buttonApplyInOutFlag.Enabled = true;
        }

        private void LoadGridviewData()
        {
            using (var context = new AppDbContext())
            {
                if (comboBoxBatchCode.SelectedValue != null)
                {
                    string batchCode = comboBoxBatchCode.SelectedValue.ToString();
                    if (batchCode == null)
                    {
                        MessageBox.Show("Select batch to proceed!","Alert");
                        return;
                    }

                    LoadBioMetricData(batchCode);
                    LoadOneEntryData(batchCode);
                    LoadTwoPlusEntryData(batchCode);
                }
                else
                {
                    MessageBox.Show("Select Batch Code!", "Batch Code");
                    comboBoxBatchCode.Focus();
                }
            }

           

            Application.DoEvents();
        }

        private void LoadBioMetricData(string batchCode)
        {
            using (var context = new AppDbContext())
            {
                var biometricLogData = context.BiometricLogs
                         .Where(bl => bl.BatchCode == batchCode)  // Filter by BatchCode
                         .Join(
                             context.Employees,
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
                             }
                         )
                         .OrderBy(bl => bl.PunchTime)  // Sorting by PunchTime
                         .ThenBy(bl => bl.BMEmployeeId) // Sorting by BMEmployeeId
                         .ToList();

                // Bind data to DataGridView
                dataGridViewBiometricLogs.DataSource = biometricLogData;
                tabPageImportedLog.Text = "#All Records " + dataGridViewBiometricLogs.RowCount + "     ";
            }
        }
        private void LoadOneEntryData(string batchCode)
        {
            using (var context = new AppDbContext())
            {
                var biometricLogDataOneEntry = context.BiometricLogs
                        .Where(bl => bl.BatchCode == batchCode)  // Filter by BatchCode
                        .AsEnumerable()  // Switch to in-memory processing
                        .GroupBy(bl => new { bl.BMEmployeeId, PunchDate = bl.PunchTime.Date }) // Group by Employee and Date
                        .Where(g => g.Count() < 2)  // Filter groups where count is NOT 2
                        .SelectMany(g => g)  // Flatten grouped data
                        .Join(
                            context.Employees.AsEnumerable(),  // Ensure Employees table is also in memory
                            bl => bl.BMEmployeeId,
                            emp => emp.BMEmployeeId,
                            (bl, emp) => new
                            {
                                bl.LogId,
                                bl.BMEmployeeId,
                                EmployeeName = emp.EmployeeName,
                                EmployeeId = emp.EmployeeId,
                                bl.PunchTime,
                                PunchDate = bl.PunchTime.Date,  // Extract date part
                                bl.DeviceId,
                                bl.PunchTypeFlag,
                                bl.VerificationMode,
                                bl.StatusCode,
                                bl.CreatedAt,
                                bl.RecordType,
                                bl.BatchCode
                            }
                        )
                        .OrderBy(bl => bl.PunchDate)  // Sorting by Date
                        .ThenBy(bl => bl.BMEmployeeId) // Sorting by BMEmployeeId
                        .ToList();

                // Bind data to DataGridView
                dataGridViewOneEntry.DataSource = biometricLogDataOneEntry;
                tabPageOneEntry.Text = "#One Entry " + dataGridViewOneEntry.RowCount + "     ";
            }
        }

        private void LoadTwoPlusEntryData(string batchCode)
        {
            using (var context = new AppDbContext())
            {
                var biometricLogDataTwoPlusEntry = context.BiometricLogs
                        .Where(bl => bl.BatchCode == batchCode)  // Filter by BatchCode
                        .AsEnumerable()  // Switch to in-memory processing
                        .GroupBy(bl => new { bl.BMEmployeeId, PunchDate = bl.PunchTime.Date }) // Group by Employee and Date
                        .Where(g => g.Count() > 2)  // Filter groups where count is NOT 2
                        .SelectMany(g => g)  // Flatten grouped data
                        .Join(
                            context.Employees.AsEnumerable(),  // Ensure Employees table is also in memory
                            bl => bl.BMEmployeeId,
                            emp => emp.BMEmployeeId,
                            (bl, emp) => new
                            {
                                bl.LogId,
                                bl.BMEmployeeId,
                                EmployeeName = emp.EmployeeName,
                                EmployeeId = emp.EmployeeId,
                                bl.PunchTime,
                                PunchDate = bl.PunchTime.Date,  // Extract date part
                                bl.DeviceId,
                                bl.PunchTypeFlag,
                                bl.VerificationMode,
                                bl.StatusCode,
                                bl.CreatedAt,
                                bl.RecordType,
                                bl.BatchCode
                            }
                        )
                        .OrderBy(bl => bl.PunchDate)  // Sorting by Date
                        .ThenBy(bl => bl.BMEmployeeId) // Sorting by BMEmployeeId
                        .ToList();

                // Bind data to DataGridView
                dataGridViewTwoPlusEntry.DataSource = biometricLogDataTwoPlusEntry;
                tabPageTwoPlusEntry.Text = "#Two Plus Entry " + dataGridViewTwoPlusEntry.RowCount + "     ";
            }
        }
        private void buttonDeleteBatchData_Click(object sender, EventArgs e)
        {
            if (dataGridViewBiometricLogs.RowCount <= 0)
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
        private void dataGridViewImportedLogs_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // Ensure the row index is valid
            if (e.RowIndex >= 0)
            {
                // Get the RecordType value from the DataGridView
                var row = dataGridViewBiometricLogs.Rows[e.RowIndex];
                var recordType = row.Cells[dgcRecordType.Name].Value?.ToString(); // Ensure column name is correct

                // Check if the record type is "MANL"
                if (recordType == "MANL")
                {
                    row.DefaultCellStyle.ForeColor = Color.Black; // Change text color to red
                    row.DefaultCellStyle.BackColor = Color.Silver; // Change text color to red
                }
            }
        }

        private void dataGridViewOneEntry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgcOneEntryAddLog.Index)
            {
                using (var context = new AppDbContext())
                {
                    int employeeId = Convert.ToInt32(dataGridViewOneEntry.Rows[e.RowIndex].Cells[dgcOneEntryEmployeeId.Name].Value);
                    int logId = Convert.ToInt32(dataGridViewOneEntry.Rows[e.RowIndex].Cells[dgcOneEntryLogId.Name].Value);
                    var employee = context.Employees.Find(employeeId);
                    var biometricLog = context.BiometricLogs.Find(logId);

                    if (employee != null && biometricLog != null)
                    {
                        FormAddManualLogAdv formAddManualLogAdv = new FormAddManualLogAdv(employee, biometricLog);
                        formAddManualLogAdv.ShowDialog();

                        LoadBioMetricData(biometricLog.BatchCode);
                        LoadOneEntryData(biometricLog.BatchCode);
                    }

                }
            }
        }

        private void dataGridViewTwoPlusEntry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgcTwoPlusEntryDeleteLog.Index)
            {
                if (MessageBox.Show("Do you want to delete this log?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridViewTwoPlusEntry.Rows[e.RowIndex].Cells[dgcTwoPlusEntryLogId.Name].Value);

                    using (var context = new AppDbContext())
                    {
                        var biometricLog = context.BiometricLogs.Find(id);
                        

                        if (biometricLog != null)
                        {
                            string batchCode = biometricLog.BatchCode;

                            context.BiometricLogs.Remove(biometricLog);
                            context.SaveChanges();

                            LoadBioMetricData(batchCode);
                            LoadTwoPlusEntryData(batchCode);
                        }
                    }
                }
            }
        }

        private void ButtonApplyInOutFlag_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to apply IN/OUT flag for selected month?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string batchCode = dataGridViewBiometricLogs.Rows[0].Cells[dgcBatchCode.Name].Value.ToString();
                if (batchCode == null)
                {
                    MessageBox.Show("System Error!\n Contact Admin.");
                    return;
                }

                using (var context = new AppDbContext())
                {
                    // Fetch Biometric Logs for the given BatchCode
                    var biometricLogs = context.BiometricLogs
                        .Where(bl => bl.BatchCode == batchCode)
                        .OrderBy(bl => bl.BMEmployeeId)
                        .ThenBy(bl => bl.PunchTime)
                        .ToList();

                    // Group by Employee and Date
                    var groupedLogs = biometricLogs
                        .GroupBy(bl => new { bl.BMEmployeeId, PunchDate = bl.PunchTime.Date });

                    foreach (var group in groupedLogs)
                    {
                        bool isIn = true;  // Start with IN

                        foreach (var log in group.OrderBy(l => l.PunchTime))  // Ensure correct order inside group
                        {
                            log.InOut = isIn ? "IN" : "OUT";
                            log.PunchTypeFlag = isIn ? 1 : 0; // Assign IN=1, OUT=0
                            isIn = !isIn; // Flip for next record
                        }
                    }

                    // Save all updates in a single call
                    context.SaveChanges();
                }
                MessageBox.Show("In/Out Process completed! \n You can now proceed to calculate monthly salary.");
            }
        }

        private void buttonDeleteLog_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete log data for selected Batch?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            var batchCode = comboBoxBatchCode.SelectedValue;
            if (batchCode == null)
            {
                MessageBox.Show("Select data to delete!", "Alert");
                return;
            }

            using (var context = new AppDbContext())
            {
                // Delete from MissingLogs
                var existingLogs = context.BiometricLogs.Where(x => x.BatchCode == batchCode).ToList();
                context.BiometricLogs.RemoveRange(existingLogs);

                context.SaveChanges();

                MessageBox.Show("Batch data deleted successfully!", "Process Complete");
            }
        }
    }
}
