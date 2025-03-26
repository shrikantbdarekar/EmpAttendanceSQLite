using EmpAttendanceSQLite.Data;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmpAttendanceSQLite.Models;

namespace EmpAttendanceSQLite
{
    public partial class FormAddManualLogAdv : Form
    {
        private readonly Employee employee;
        private readonly BiometricLog existingBiometricLog;

        public FormAddManualLogAdv(Employee employee, BiometricLog existingBiometricLog)
        {
            InitializeComponent();

            this.employee = employee;
            this.existingBiometricLog = existingBiometricLog;
        }

        private void FormCompanyInfo_Load(object sender, EventArgs e)
        {
            // Read existing data 
            if (employee != null)
            {
                textBoxEmployeeName.Text = employee.EmployeeName;
                textBoxBMEmployeeCode.Text = employee.BMEmployeeId.ToString();
                textBoxEmployeeCode.Text = employee.EmployeeCode;
            }

            if (existingBiometricLog != null)
            {
                textBoxPunchDate.Text = existingBiometricLog.PunchTime.ToString("dd/MM/yyyy hh:mm tt");
                labelPunchDateToAdd.Text = existingBiometricLog.PunchTime.ToString("dd/MM/yyyy");

                if (textBoxPunchDate.Text.Trim().EndsWith("AM", StringComparison.OrdinalIgnoreCase))
                {
                    dtpPunchTimeToAdd.Value = DateTime.Today.AddHours(18).AddMinutes(0); // 6:00 PM
                }
                else if (textBoxPunchDate.Text.Trim().EndsWith("PM", StringComparison.OrdinalIgnoreCase))
                {
                    dtpPunchTimeToAdd.Value = DateTime.Today.AddHours(8).AddMinutes(30); // 8:30 AM
                }

            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DateTime punchTimeToAdd = new DateTime(
                        DateOnly.FromDateTime(existingBiometricLog.PunchTime),
                        TimeOnly.FromDateTime(dtpPunchTimeToAdd.Value)
                        );

            using (var context = new AppDbContext())
            {
                // Add record to BiometricLogs | MANL
                var manualEntry = new BiometricLog
                {
                    BMEmployeeId = existingBiometricLog.BMEmployeeId,
                    PunchTime = punchTimeToAdd,
                    PunchTypeFlag = existingBiometricLog.PunchTypeFlag, // Admin selects IN or OUT
                    DeviceId = existingBiometricLog.DeviceId,
                    VerificationMode = existingBiometricLog.VerificationMode, // Manual Entry Code
                    StatusCode = existingBiometricLog.StatusCode,
                    RecordType = "MANL",
                    BatchCode = existingBiometricLog.BatchCode,
                    StartDate=existingBiometricLog.StartDate,
                    EndDate=existingBiometricLog.EndDate,
                    CreatedAt = DateTime.UtcNow
                };

                context.BiometricLogs.Add(manualEntry);
                context.SaveChanges();

                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
