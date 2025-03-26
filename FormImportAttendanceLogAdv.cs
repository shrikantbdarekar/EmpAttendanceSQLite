using EmpAttendanceSQLite.Data;
using EmpAttendanceSQLite.Models;
using System.Windows.Forms;

namespace EmpAttendanceSQLite
{
    public partial class FormImportAttendanceLogAdv : Form
    {
        //private string batchCode = string.Empty;
        //private string importMessage = string.Empty;
        public FormImportAttendanceLogAdv()
        {
            InitializeComponent();
        }

        private void FormImportAttendanceLog_Load(object sender, EventArgs e)
        {
            // Visible for super admin only
            if (Program.loginUser.Role == (int)UserRoles.SuperAdmin)
            {
                dgcHistoryDelete.Visible = true;
            }

            DateTime now = DateTime.Now;

            // Get the first day of the previous month
            DateTime firstDayOfPreviousMonth = new DateTime(now.Year, now.Month, 1).AddMonths(-1);
            // Get the last day of the previous month
            DateTime lastDayOfPreviousMonth = firstDayOfPreviousMonth.AddMonths(1).AddDays(-1);

            dtpStartDate.Value = firstDayOfPreviousMonth;
            dtpEndDate.Value = lastDayOfPreviousMonth;

            dataGridViewBiometricLogs.AutoGenerateColumns = false;
            dataGridViewBatchHistory.AutoGenerateColumns = false;

            LoadBatchHistory();
        }

        private void LoadBatchHistory()
        {
            using (var context = new AppDbContext())
            {
                var batchCodes = context.BiometricLogs
                    .GroupBy(x => new { x.BatchCode, x.StartDate, x.EndDate }) // Group by all three
                    .Select(g => new
                    {
                        g.Key.BatchCode,
                        g.Key.StartDate,
                        g.Key.EndDate
                    })
                    .OrderBy(x => x.StartDate) // Order by StartDate
                    .ToList();

                dataGridViewBatchHistory.DataSource = batchCodes;
                dataGridViewBiometricLogs.DataSource = null;

                tabPageBatchHistory.Text = "# Batch History (" + dataGridViewBatchHistory.RowCount + ")";
            }

        }

        private void buttonBrowseFile_Click(object sender, EventArgs e)
        {
            openAttendanceLogFileDialog.ShowDialog();
            string fileName = openAttendanceLogFileDialog.FileName;
            textBoxFileName.Text = fileName;
        }
        private void buttonImportData_Click(object sender, EventArgs e)
        {
            if (textBoxFileName.Text == string.Empty)
            {
                MessageBox.Show("Select file to import data!", "Alert");
                return;
            }

            try
            {
                string fileName = textBoxFileName.Text;

                DateTime FD = dtpStartDate.Value;
                DateTime TD = dtpEndDate.Value;

                DateTime fromDate = new DateTime(FD.Year, FD.Month, FD.Day, 0, 1, 0);
                DateTime toDate = new DateTime(TD.Year, TD.Month, TD.Day, 23, 59, 0);


                string batchCode = "BCODE-" + DateTime.Now.ToString("yyyyMMddhhmmss").ToString();

                if (File.Exists(fileName))
                {
                    FormSplash formSplash = new FormSplash();
                    formSplash.Show();
                    Application.DoEvents();

                    ImportBiometricLogs(fileName, batchCode, fromDate, toDate);

                    formSplash.Close();

                    LoadBatchHistory();
                    LoadBatchData(batchCode);
                }
                else
                {
                    MessageBox.Show("Data import canceld!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Data import failed!");
            }
        }

        private void LoadBatchData(string batchCode)
        {
            using (var context = new AppDbContext())
            {
                var biometricLogData = (from bl in context.BiometricLogs
                                        join emp in context.Employees on bl.BMEmployeeId equals emp.BMEmployeeId
                                        where bl.BatchCode == batchCode // Filter by BatchCode
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

                dataGridViewBiometricLogs.DataSource = biometricLogData;

                labelBatchCode.Text = "Batch Code\n" + batchCode;
                tabPageRawLogs.Text = "#Raw Log Data (" + dataGridViewBiometricLogs.RowCount + ")    ";

                tabControlMain.SelectedTab = tabPageRawLogs; // Ensure the tab is selected
                tabPageRawLogs.Focus(); // Set focus on the tab
            }
        }
        private void ImportBiometricLogs(string filePath, string batchCode, DateTime startDate, DateTime endDate)
        {
            int insertedCount = 0;
            int duplicateCount = 0;

            var lines = File.ReadAllLines(filePath);
            using (var context = new AppDbContext())
            {
                foreach (var line in lines)
                {
                    var parts = line.Split('\t'); // Assuming tab-separated 6 values

                    if (parts.Length != 6)
                    {
                        MessageBox.Show("File contains data having less than 6 columns");
                    }

                    int employeeId = int.Parse(parts[0]);
                    DateTime punchTime = DateTime.Parse(parts[1]);
                    int deviceId = 0; int.TryParse(parts[2], out deviceId);
                    int punchTypeFlag = 0; int.TryParse(parts[3], out punchTypeFlag);
                    int verificationMode = 0; int.TryParse(parts[4], out verificationMode);
                    int statusCode = 0; int.TryParse(parts[5], out statusCode);

                    // Check if the record already exists
                    bool existingData = context.BiometricLogs
                        .Any(b => b.BMEmployeeId == employeeId && b.PunchTime == punchTime);

                    // Import data for selected month duratuin only.
                    bool isValidDate = false;
                    if (punchTime.Date >= startDate.Date && punchTime.Date <= endDate.Date)
                        isValidDate = true;

                    // Insert only if data doesn't exist
                    // and data is for selected month
                    if (!existingData && isValidDate)
                    {
                        context.BiometricLogs.Add(new BiometricLog
                        {
                            BMEmployeeId = employeeId,
                            PunchTime = punchTime,
                            DeviceId = deviceId,
                            PunchTypeFlag = punchTypeFlag,
                            VerificationMode = verificationMode,
                            StatusCode = statusCode,
                            CreatedAt = DateTime.UtcNow,
                            RecordType = RecordTypes.AUTO.ToString(),
                            BatchCode = batchCode,
                            StartDate = startDate,
                            EndDate = endDate
                        });

                        ++insertedCount;
                    }
                    else
                    {
                        ++duplicateCount;
                    }
                }
                context.SaveChanges();

                string importMessage = "Inserted " + insertedCount.ToString() + " records out of " + (insertedCount + duplicateCount) + " records.";
                MessageBox.Show(importMessage, "Process Complete");
            }
        }

        private void UpdateAlternateInOut(string batchCode)
        {
            using (var context = new AppDbContext())
            {
                // Update PunchTypeFlag
                // Logic Applied : Alternate IN/OUT
                var biometricLogs = context.BiometricLogs
                    .Where(bl => bl.BatchCode == batchCode)
                    .OrderBy(bl => bl.BMEmployeeId)
                    .ThenBy(bl => bl.PunchTime)
                    .ToList();

                var groupedLogs = biometricLogs
                    .GroupBy(bl => new { bl.BMEmployeeId, bl.PunchTime.Date });

                foreach (var group in groupedLogs)
                {
                    bool isIn = true;  // Start with IN

                    foreach (var log in group)
                    {
                        log.InOut = isIn ? "IN" : "OUT";
                        log.PunchTypeFlag = isIn ? 1 : 0; // Assign IN=1, OUT=0
                        isIn = !isIn; // Flip for next record
                    }
                }
                context.SaveChanges();  // Save the updated PunchTypeFlag
            }
        }
        private void AddMissingLogEntry(string batchCode)
        {
            using (var context = new AppDbContext())
            {
                var biometricLogs = context.BiometricLogs
                    .Where(b => b.BatchCode == batchCode)
                    .OrderBy(bl => bl.BMEmployeeId)
                    .ThenBy(bl => bl.PunchTime)
                    .ToList();

                var groupedLogs = biometricLogs
                    .Where(b => b.BatchCode == batchCode)
                    .GroupBy(bl => new { bl.BMEmployeeId, bl.PunchTime.Date });

                List<MissingLog> missingLogs = new List<MissingLog>();

                foreach (var group in groupedLogs)
                {
                    var logs = group.ToList();
                    if (logs.Count % 2 != 0) // Odd number of entries = Missing punch
                    {
                        var lastLog = logs.Last();

                        missingLogs.Add(new MissingLog
                        {
                            BMEmployeeId = lastLog.BMEmployeeId,
                            PunchDate = lastLog.PunchTime.Date,
                            MissingType = lastLog.PunchTypeFlag == 1 ? "OUT Missing" : "IN Missing",
                            CreatedAt = DateTime.UtcNow,
                            BatchCode = lastLog.BatchCode
                        });
                    }
                }

                if (missingLogs.Any())
                {
                    context.MissingLogs.AddRange(missingLogs);
                    context.SaveChanges(); // Save Missing Logs
                }
            }

            //using (var context = new AppDbContext())
            //{
            //    var groupedLogs = context.BiometricLogs
            //        .Where(b => b.BatchCode == batchCode)
            //    //.Where(b => b.PunchTime >= VirtualFromDate && b.PunchTime <= VirtuaToDate)
            //    .GroupBy(b => new { b.BMEmployeeId, b.PunchTime.Date })
            //    .Select(g => new
            //    {
            //        EmployeeId = g.Key.BMEmployeeId,
            //        Date = g.Key.Date,
            //        InPunch = g.FirstOrDefault(p => p.PunchTypeFlag == 0), // IN punch
            //        OutPunch = g.FirstOrDefault(p => p.PunchTypeFlag == 1), // OUT punch
            //        AllPunches = g.ToList()
            //    })
            //    .ToList();

            //    // Identify missing punches
            //    var missingPunches = new List<MissingLog>();
            //    foreach (var log in groupedLogs)
            //    {
            //        if (log.InPunch == null || log.OutPunch == null)
            //        {
            //            missingPunches.Add(new MissingLog
            //            {
            //                BMEmployeeId = log.EmployeeId,
            //                PunchDate = log.Date,
            //                MissingType = log.InPunch == null ? "Missing IN" : "Missing OUT",
            //                CreatedAt = DateTime.UtcNow,
            //                BatchCode = batchCode
            //            });
            //        }
            //    }

            //    // Insert missing logs into `MissingLogs` table
            //    context.MissingLogs.AddRange(missingPunches);
            //    context.SaveChanges();
            //}
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.Value = dtpStartDate.Value.AddMonths(1).AddDays(-1);
        }

        private void dataGridViewBatchHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string batchCode = dataGridViewBatchHistory.Rows[e.RowIndex].Cells[dgcHistoryBatchCode.Name].Value.ToString();

            if (e.ColumnIndex == dgcHistoryView.Index)
            {
                if (batchCode != null && batchCode != string.Empty)
                {
                    LoadBatchData(batchCode);

                }
            }
            else if (e.ColumnIndex == dgcHistoryDelete.Index)
            {
                if (MessageBox.Show("Do you want to delete log data for selected Batch?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }

                using (var context = new AppDbContext())
                {
                    // Delete from MissingLogs
                    var missingLogs = context.MissingLogs.Where(x => x.BatchCode == batchCode).ToList();
                    context.MissingLogs.RemoveRange(missingLogs);

                    // Delete from BiometricLogs
                    var biometricLogs = context.BiometricLogs.Where(x => x.BatchCode == batchCode).ToList();
                    context.BiometricLogs.RemoveRange(biometricLogs);

                    context.SaveChanges();

                    MessageBox.Show("Batch data deleted successfully!", "Process Complete");

                    LoadBatchHistory();
                }
            }
        }
    }
}
