using EmpAttendanceSQLite.Data;
using EmpAttendanceSQLite.Models;
using System.Windows.Forms;

namespace EmpAttendanceSQLite
{
    public partial class FormImportAttendanceLog : Form
    {
        private string batchCode = string.Empty;
        private string importMessage = string.Empty;
        public FormImportAttendanceLog()
        {
            InitializeComponent();
        }

        private void FormImportAttendanceLog_Load(object sender, EventArgs e)
        {
        }

        private void buttonBrowseFile_Click(object sender, EventArgs e)
        {
            openAttendanceLogFileDialog.ShowDialog();
            string fileName = openAttendanceLogFileDialog.FileName;
            textBoxFileName.Text = fileName;
        }
        private void buttonImportData_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fromDate = dtpFromDate.Value;
                DateTime toDate = dtpToDate.Value;
                string fileName = textBoxFileName.Text;

                if (File.Exists(fileName))
                {
                    FormSplash formSplash = new FormSplash();
                    formSplash.Show();
                    Application.DoEvents();

                    ImportBiometricLogs(fileName, fromDate, toDate);
                    UpdateAlternateInOut();
                    AddMissingLogEntry();

                    formSplash.Close();


                    FormImportView formImportView = new FormImportView(batchCode, importMessage);
                    formImportView.ShowDialog();
                    Application.DoEvents();

                    //buttonLogin.Enabled = false;
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

        private void ImportBiometricLogs(string filePath, DateTime fromDate, DateTime toDate)
        {
            int insertedCount = 0;
            int duplicateCount = 0;
            batchCode = "BCODE-" + DateTime.Now.ToString("yyyyMMddhhmmss").ToString();

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
                    if (punchTime.Date >= fromDate.Date && punchTime.Date <= toDate.Date)
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
                            BatchCode = batchCode
                        });

                        ++insertedCount;
                    }
                    else
                    {
                        ++duplicateCount;
                    }
                }
                context.SaveChanges();

                importMessage = "Inserted " + insertedCount.ToString() + " records out of " + (insertedCount + duplicateCount) + " records.";
            }
        }

        private void UpdateAlternateInOut()
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
        private void AddMissingLogEntry()
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
            dtpToDate.Value = dtpFromDate.Value.AddMonths(1).AddDays(-1);
        }
    }
}
