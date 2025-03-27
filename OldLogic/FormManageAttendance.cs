using EmpAttendanceSQLite.Data;
using EmpAttendanceSQLite.Models;
using Microsoft.VisualBasic.Logging;
using System.Windows.Forms;

namespace EmpAttendanceSQLite
{
    public partial class FormManageAttendance : Form
    {
        private DateTime VirtualFromDate = new DateTime(2025, 3, 1);
        private DateTime VirtuaToDate = new DateTime(2025, 3, 25);
        public FormManageAttendance()
        {
            InitializeComponent();

            dataGridViewMain.AutoGenerateColumns = false;
        }

        private void FormImportAttendanceLog_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            // Get the first day of the previous month
            DateTime firstDayOfPreviousMonth = new DateTime(now.Year, now.Month, 1).AddMonths(-1);

            // Get the last day of the previous month
            DateTime lastDayOfPreviousMonth = firstDayOfPreviousMonth.AddMonths(1).AddDays(-1);

            dtpFromDate.Value = firstDayOfPreviousMonth;
            dtpToDate.Value = lastDayOfPreviousMonth;

            using (var context = new AppDbContext())
            {
                var employeeList = context.Employees
                    .OrderBy(e => e.BMEmployeeId) // Order by BMEmployeeId
                    .Select(e => new
                    {
                        e.EmployeeId,
                        e.EmployeeCode,
                        e.BMEmployeeId,
                        e.EmployeeName
                    })
                    .ToList();

                // Insert default item at index 0
                employeeList.Insert(0, new { EmployeeId = 0, EmployeeCode = "NA", BMEmployeeId = 0, EmployeeName = "Select Employee" });

                comboBoxEmployee.DataSource = employeeList;
                comboBoxEmployee.DisplayMember = "EmployeeName";  // Shown in dropdown
                comboBoxEmployee.ValueMember = "EmployeeId";      // Stored value
            }
        }


        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dtpFromDate.Value.Date;  // Get selected From Date
            DateTime toDate = dtpToDate.Value.Date; // Get selected To Date

            //int employeeId = comboBoxEmployee.SelectedValue == null ? 0 : (int)comboBoxEmployee.SelectedValue;
            int bmEmployeeId = 0;

            var selectedItem = comboBoxEmployee.SelectedItem;
            if (selectedItem != null)
            {
                bmEmployeeId = (int)selectedItem.GetType().GetProperty("BMEmployeeId").GetValue(selectedItem, null);
            }

            using (var context = new AppDbContext())
            {
                if (bmEmployeeId == 0)
                {

                    var biometricLogData = (from bl in context.BiometricLogs
                                            join emp in context.Employees on bl.BMEmployeeId equals emp.BMEmployeeId
                                            where bl.PunchTime >= fromDate && bl.PunchTime <= toDate  // Apply date range filter
                                            orderby bl.BMEmployeeId, bl.PunchTime  // Sorting first by PunchTime, then by BMEmployeeId
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
                                                bl.BatchCode,
                                                bl.InOut,
                                                bl.ManualEntryRemark
                                            }).ToList();

                    dataGridViewMain.DataSource = biometricLogData;
                    labelTotal.Text = "Total Rows: " + dataGridViewMain.Rows.Count.ToString();
                }
                else
                {
                    var biometricLogData = (from bl in context.BiometricLogs
                                            join emp in context.Employees on bl.BMEmployeeId equals emp.BMEmployeeId
                                            where bl.PunchTime >= fromDate && bl.PunchTime <= toDate && bl.BMEmployeeId == bmEmployeeId // Apply date range filter
                                            orderby bl.BMEmployeeId, bl.PunchTime  // Sorting first by PunchTime, then by BMEmployeeId
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

                    //var filteredData = context.BiometricLogs
                    //    .Where(b => b.PunchTime >= fromDate && b.PunchTime <= toDate && b.BMEmployeeId == bmEmployeeId)
                    //    .ToList();

                    dataGridViewMain.DataSource = biometricLogData;
                    labelTotal.Text = "Total Rows: " + dataGridViewMain.Rows.Count.ToString();
                }
            }
        }

        private void buttonInOut_Click(object sender, EventArgs e)
        {
            MissingLogPunchType();
        }

        private void buttonAmPm_Click(object sender, EventArgs e)
        {
            MissingLogPunchTypeAmPm();
        }

        private void MissingLogPunchType()
        {
            using (var context = new AppDbContext())
            {

                var groupedLogs = context.BiometricLogs
                    .Where(b => b.PunchTime >= VirtualFromDate && b.PunchTime <= VirtuaToDate)
                .GroupBy(b => new { b.BMEmployeeId, b.PunchTime.Date })
                .Select(g => new
                {
                    EmployeeId = g.Key.BMEmployeeId,
                    Date = g.Key.Date,
                    InPunch = g.FirstOrDefault(p => p.PunchTypeFlag == 0), // IN punch
                    OutPunch = g.FirstOrDefault(p => p.PunchTypeFlag == 1), // OUT punch
                    AllPunches = g.ToList()
                })
                .ToList();
                dataGridView1.DataSource = groupedLogs;

                // Identify missing punches
                var missingPunches = new List<MissingLog>();
                foreach (var log in groupedLogs)
                {
                    if (log.InPunch == null || log.OutPunch == null)
                    {
                        missingPunches.Add(new MissingLog
                        {
                            BMEmployeeId = log.EmployeeId,
                            PunchDate = log.Date,
                            MissingType = log.InPunch == null ? "Missing IN" : "Missing OUT",
                            CreatedAt = DateTime.UtcNow
                        });
                    }
                }

                // Insert missing logs into `MissingLogs` table
                context.MissingLogs.AddRange(missingPunches);
                context.SaveChanges();
            }
        }

        private void MissingLogPunchTypeAmPm()
        {
            using (var context = new AppDbContext())
            {
                var groupedLogs = context.BiometricLogs
                    .Where(b => b.PunchTime >= VirtualFromDate && b.PunchTime <= VirtuaToDate)
                    .GroupBy(b => new { b.BMEmployeeId, b.PunchTime.Date })
                    .Select(g => new
                    {
                        EmployeeId = g.Key.BMEmployeeId,
                        Date = g.Key.Date,
                        InPunch = g.FirstOrDefault(p => p.PunchTypeFlag == 0), // IN punch
                        OutPunch = g.FirstOrDefault(p => p.PunchTypeFlag == 1), // OUT punch
                        AllPunches = g.ToList()
                    })
                    .ToList();

                dataGridView2.DataSource = groupedLogs;

                foreach (var log in groupedLogs)
                {
                    var inPunch = log.AllPunches.FirstOrDefault(p => p.PunchTime.TimeOfDay < TimeSpan.FromHours(12)); // Before 12 PM
                    var outPunch = log.AllPunches.FirstOrDefault(p => p.PunchTime.TimeOfDay >= TimeSpan.FromHours(12)); // After 12 PM

                    if (inPunch == null || outPunch == null)
                    {
                        context.MissingLogs.Add(new MissingLog
                        {
                            BMEmployeeId = log.EmployeeId,
                            PunchDate = log.Date,
                            MissingType = inPunch == null ? "Missing IN" : "Missing OUT",
                            CreatedAt = DateTime.UtcNow
                        });
                    }
                }
            }
        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            dtpToDate.Value = dtpFromDate.Value.AddMonths(1).AddDays(-1);
        }
    }
}
