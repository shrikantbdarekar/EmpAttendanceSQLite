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

        private void buttonImport_Click(object sender, EventArgs e)
        {
            try
            {
                openAttendanceLogFileDialog.ShowDialog();
                string fileName = openAttendanceLogFileDialog.FileName;
                textBoxFileName.Text = fileName;

                if (File.Exists(fileName))
                {
                    FormSplash formSplash = new FormSplash();
                    formSplash.Show();
                    Application.DoEvents();

                    ImportBiometricLogs(fileName);

                    formSplash.Close();
                    Application.DoEvents();

                    FormImportView formImportView = new FormImportView(batchCode, importMessage);
                    formImportView.ShowDialog();
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

        private void ImportBiometricLogs(string filePath)
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
                    bool exists = context.BiometricLogs
                        .Any(b => b.BMEmployeeId == employeeId && b.PunchTime == punchTime);

                    if (!exists) // Insert only if it doesn't exist
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
                            BatchCode= batchCode
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

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
