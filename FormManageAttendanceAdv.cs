using EmpAttendanceSQLite.Data;
using EmpAttendanceSQLite.Models;
using EmpAttendanceSQLite.Reports;
using Microsoft.VisualBasic.Logging;
using System.Windows.Forms;

namespace EmpAttendanceSQLite
{
    public partial class FormManageAttendanceAdv : Form
    {
        private DateTime VirtualFromDate = new DateTime(2025, 3, 1);
        private DateTime VirtuaToDate = new DateTime(2025, 3, 25);
        public FormManageAttendanceAdv()
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

                    //var biometricLogData = (from bl in context.BiometricLogs
                    //                        join emp in context.Employees on bl.BMEmployeeId equals emp.BMEmployeeId
                    //                        where bl.PunchTime >= fromDate && bl.PunchTime < toDate.AddDays(1) // Corrected date range filter
                    //                        orderby bl.BMEmployeeId, bl.PunchTime // Sorting first by BMEmployeeId, then by PunchTime
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
                    //                            bl.BatchCode,
                    //                            bl.InOut,
                    //                            bl.ManualEntryRemark
                    //                        }).ToList();


                    //dataGridViewMain.DataSource = biometricLogData;
                    //labelTotal.Text = "Total Rows: " + dataGridViewMain.Rows.Count.ToString();
                }
                else
                {
                    //var biometricLogData = (from bl in context.BiometricLogs
                    //                        join emp in context.Employees on bl.BMEmployeeId equals emp.BMEmployeeId
                    //                        where bl.BMEmployeeId == bmEmployeeId // First filter Employee
                    //                              && bl.PunchTime >= fromDate
                    //                              && bl.PunchTime < toDate.AddDays(1) // Ensure full-day coverage
                    //                        orderby bl.BMEmployeeId, bl.PunchTime // Sorting first by Employee, then PunchTime
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
                    //                            bl.BatchCode,
                    //                            bl.InOut,
                    //                            bl.ManualEntryRemark
                    //                        }).ToList();

                    //dataGridViewMain.DataSource = biometricLogData;
                    //labelTotal.Text = "Total Rows: " + dataGridViewMain.Rows.Count.ToString();


                    //var biometricLogDailyHours = context.BiometricLogs
                    //    .Where(bl => bl.BMEmployeeId == bmEmployeeId
                    //                 && bl.PunchTime >= fromDate
                    //                 && bl.PunchTime < toDate.AddDays(1))
                    //    .Join(context.Employees,
                    //          bl => bl.BMEmployeeId,
                    //          emp => emp.BMEmployeeId,
                    //          (bl, emp) => new
                    //          {
                    //              bl.LogId,
                    //              bl.BMEmployeeId,
                    //              EmployeeName = emp.EmployeeName,
                    //              EmployeeId = emp.EmployeeId,
                    //              bl.PunchTime,
                    //              bl.PunchTypeFlag,
                    //              bl.DeviceId,
                    //              bl.VerificationMode,
                    //              bl.StatusCode,
                    //              bl.CreatedAt,
                    //              bl.RecordType,
                    //              bl.BatchCode
                    //          })
                    //    .GroupBy(bl => new { bl.BMEmployeeId, bl.PunchTime.Date }) // Group by Employee & Date
                    //    .Select(g => new
                    //    {
                    //        BMEmployeeId = g.Key.BMEmployeeId,
                    //        EmployeeName = g.First().EmployeeName,
                    //        EmployeeId = g.First().EmployeeId,
                    //        PunchDate = g.Key.Date,
                    //        IN = g.Where(x => x.PunchTypeFlag == 1).Select(x => x.PunchTime).FirstOrDefault(),
                    //        OUT = g.Where(x => x.PunchTypeFlag == 0).Select(x => x.PunchTime).FirstOrDefault(),
                    //        TotalHours = g.Where(x => x.PunchTypeFlag == 1).Select(x => x.PunchTime).FirstOrDefault() != null &&
                    //         g.Where(x => x.PunchTypeFlag == 0).Select(x => x.PunchTime).FirstOrDefault() != null
                    //         ? Math.Round((g.Where(x => x.PunchTypeFlag == 0).Select(x => x.PunchTime).FirstOrDefault() -
                    //                       g.Where(x => x.PunchTypeFlag == 1).Select(x => x.PunchTime).FirstOrDefault()).TotalHours, 2)
                    //         : 0

                    //    })
                    //    .OrderBy(x => x.BMEmployeeId)
                    //    .ThenBy(x => x.PunchDate)
                    //    .ToList();

                    List<EmployeeAttendanceReportModel> biometricLogDailyHours = context.BiometricLogs
    .Where(bl => bl.BMEmployeeId == bmEmployeeId
                 && bl.PunchTime >= fromDate
                 && bl.PunchTime < toDate.AddDays(1))
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
              bl.PunchTypeFlag,
              bl.DeviceId,
              bl.VerificationMode,
              bl.StatusCode,
              bl.CreatedAt,
              bl.RecordType,
              bl.BatchCode
          })
            .GroupBy(bl => new { bl.BMEmployeeId, bl.PunchTime.Date })
            .Select(g => new EmployeeAttendanceReportModel
            {
                BMEmployeeId = g.Key.BMEmployeeId,
                EmployeeName = g.First().EmployeeName,
                EmployeeId = g.First().EmployeeId,
                PunchDate = g.Key.Date,
                In = g.Where(x => x.PunchTypeFlag == 1).Select(x => x.PunchTime).FirstOrDefault(),
                Out = g.Where(x => x.PunchTypeFlag == 0).Select(x => x.PunchTime).FirstOrDefault(),
                TotalHours = g.Where(x => x.PunchTypeFlag == 1).Select(x => x.PunchTime).FirstOrDefault() != null &&
                             g.Where(x => x.PunchTypeFlag == 0).Select(x => x.PunchTime).FirstOrDefault() != null
                             ? Math.Round((g.Where(x => x.PunchTypeFlag == 0).Select(x => x.PunchTime).FirstOrDefault() -
                                   g.Where(x => x.PunchTypeFlag == 1).Select(x => x.PunchTime).FirstOrDefault()).TotalHours, 2)
                             : 0
            })
            .OrderBy(x => x.BMEmployeeId)
            .ThenBy(x => x.PunchDate)
            .ToList();


                    dataGridView1.DataSource = biometricLogDailyHours;

                    FormReportViewer formReportViewer = new FormReportViewer(ReportTypes.MonthlySalaryReport, biometricLogDailyHours);
                    formReportViewer.ShowDialog();
                }

                tabPageOrderByEmpIdTime.Text = "#Order By BM Employee Id (" + dataGridViewMain.RowCount + ")     ";
            }
        }
        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            dtpToDate.Value = dtpFromDate.Value.AddMonths(1).AddDays(-1);
        }

        private void buttonMonthlySalary_Click(object sender, EventArgs e)
        {



            //using (var context = new AppDbContext())
            //{
            //    var attendanceData = context.BiometricLogs
            //        .Join(context.Employees,
            //            bl => bl.BMEmployeeId,
            //            emp => emp.BMEmployeeId,
            //            (bl, emp) => new { bl, emp })
            //        .GroupBy(x => new { x.emp.EmployeeId, x.emp.EmployeeName, PunchDate = x.bl.PunchTime.Date })
            //        .Select(g => new EmployeeAttendanceReportModel
            //        {
            //            EmployeeId = g.Key.EmployeeId,
            //            EmployeeName = g.Key.EmployeeName,
            //            PunchDate = g.Key.PunchDate,
            //            InTime = g.Where(x => x.bl.PunchTypeFlag == 1).Select(x => x.bl.PunchTime.TimeOfDay).FirstOrDefault(),
            //            OutTime = g.Where(x => x.bl.PunchTypeFlag == 0).Select(x => x.bl.PunchTime.TimeOfDay).FirstOrDefault(),
            //            TotalHours = Math.Round((decimal)
            //                (g.Where(x => x.bl.PunchTypeFlag == 0).Select(x => x.bl.PunchTime).FirstOrDefault() -
            //                 g.Where(x => x.bl.PunchTypeFlag == 1).Select(x => x.bl.PunchTime).FirstOrDefault()).TotalHours, 2),
            //            HourlySalary = g.Select(x => x.emp.HourlySalary).FirstOrDefault()
            //        })
            //        .ToList();

            //    // Calculate total salary for report footer
            //    decimal totalSalary = attendanceData.Sum(x => x.TotalSalary);
            //    //string totalSalaryInWords = ConvertToWords((int)totalSalary);
        }
    }
}

