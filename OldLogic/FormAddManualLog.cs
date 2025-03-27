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
using EmpAttendanceSQLite.Data;
using EmpAttendanceSQLite.Models;

namespace EmpAttendanceSQLite
{
    public partial class FormAddManualLog : Form
    {
        private readonly Employee employee;
        private readonly MissingLog missingLog;

        public FormAddManualLog(Employee employee, MissingLog missingLog)
        {
            InitializeComponent();

            this.employee = employee;
            this.missingLog = missingLog;
        }

        private void FormCompanyInfo_Load(object sender, EventArgs e)
        {
            // Set PunchType data source
            var punchTypesDictionary = new Dictionary<int, string>
                {
                    { 0, "IN" },
                    { 1, "OUT" }
                };

            comboBoxPunchType.DataSource = new BindingSource(punchTypesDictionary, null);
            comboBoxPunchType.DisplayMember = "Value";  // Display "IN" / "OUT"
            comboBoxPunchType.ValueMember = "Key";      // Store 0 / 1

            // Set Machine data source
            using (var context = new AppDbContext())
            {
                var machineList = context.BiometricMachines
                    .OrderBy(e => e.MachineName) // Order by BMEmployeeId
                    .Select(e => new
                    {
                        e.MachineId,
                        e.MachineName,
                    })
                    .ToList();

                // Insert default item at index 0
                machineList.Insert(0, new { MachineId = 0, MachineName = "Select" });

                comboBoxMachines.DataSource = machineList;
                comboBoxMachines.DisplayMember = "MachineName";  // Shown in dropdown
                comboBoxMachines.ValueMember = "MachineId";      // Stored value

                if (machineList.Count == 2)
                    comboBoxMachines.SelectedIndex = 1;
            }

            // Read existing data 
            if (employee != null)
            {
                textBoxEmployeeName.Text = employee.EmployeeName;
                textBoxBMEmployeeCode.Text = employee.BMEmployeeId.ToString();
                textBoxEmployeeCode.Text = employee.EmployeeCode;
            }

            if (missingLog != null)
            {
                DateTime punchTimeModified = DateTime.Now;
                labelMissingFlag.Text = missingLog.MissingType;

                if (missingLog.MissingType == "Missing IN")
                {
                    punchTimeModified = new DateTime(
                        DateOnly.FromDateTime(missingLog.PunchDate), 
                        TimeOnly.FromTimeSpan(employee.ShiftStart)
                        );

                    // Set default value
                    comboBoxPunchType.SelectedValue = 0; // IN
                }
                else if (missingLog.MissingType == "Missing OUT")
                {
                    punchTimeModified = new DateTime(
                        DateOnly.FromDateTime(missingLog.PunchDate),
                        TimeOnly.FromTimeSpan(employee.ShiftEnd)
                        );

                    // Set default value
                    comboBoxPunchType.SelectedValue = 1; // OUT
                }

                dtpPunchTime.Value = punchTimeModified; //missingLog.PunchDate;
                labelPunchDate.Text = missingLog.PunchDate.ToString("dd/MM/yyyy");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DateTime punchTimeModified = new DateTime(
                        DateOnly.FromDateTime(missingLog.PunchDate),
                        TimeOnly.FromDateTime(dtpPunchTime.Value)
                        );

            using (var context = new AppDbContext())
            {
                // Add record to BiometricLogs | MANL
                var manualEntry = new BiometricLog
                {
                    BMEmployeeId = missingLog.BMEmployeeId,
                    PunchTime = dtpPunchTime.Value,
                    PunchTypeFlag = (int)comboBoxPunchType.SelectedValue, // Admin selects IN or OUT
                    DeviceId = (int)comboBoxMachines.SelectedValue,
                    VerificationMode = 1, // Manual Entry Code
                    StatusCode = 0,
                    RecordType = "MANL",
                    BatchCode = missingLog.BatchCode,
                    CreatedAt = DateTime.UtcNow
                };

                context.BiometricLogs.Add(manualEntry);
                context.SaveChanges();

                // Remove record from Missing Logs
                var missingRecord = context.MissingLogs.FirstOrDefault(m => m.MissingLogId == missingLog.MissingLogId);
                if (missingRecord != null)
                {
                    context.MissingLogs.Remove(missingRecord);
                    context.SaveChanges();

                    this.Close();
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
