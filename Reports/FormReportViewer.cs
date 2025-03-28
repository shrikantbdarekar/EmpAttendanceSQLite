using Microsoft.Reporting.WinForms;
using EmpAttendanceSQLite.Data;
using EmpAttendanceSQLite.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpAttendanceSQLite.Reports
{
    public partial class FormReportViewer : Form
    {
        private readonly ReportViewer reportViewer;
        public FormReportViewer()
        {
            InitializeComponent();

            Text = "Report viewer";
            //WindowState = FormWindowState.Maximized;
            reportViewer = new ReportViewer();
            reportViewer.Dock = DockStyle.Fill;

            reportViewer.ShowBackButton = false;
            reportViewer.ShowRefreshButton = false;
            reportViewer.ShowExportButton = false;
            reportViewer.ShowStopButton = false;
            reportViewer.ShowParameterPrompts = false;
            reportViewer.ShowFindControls = false;
            reportViewer.ShowZoomControl = false;

            //reportViewer.di = DisplayMode.Normal;//DisplayMode.PrintLayout;

            this.Controls.Add(reportViewer);
            Application.DoEvents();
        }

        private void LoadReport()
        {
            Report.Load(reportViewer.LocalReport);
            reportViewer.RefreshReport();

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
            //            //TotalHours = Math.Round(
            //            //    (g.Where(x => x.bl.PunchTypeFlag == 0).Select(x => x.bl.PunchTime).FirstOrDefault() -
            //            //     g.Where(x => x.bl.PunchTypeFlag == 1).Select(x => x.bl.PunchTime).FirstOrDefault()).TotalHours, 2),
            //            TotalHours = Math.Round((decimal)((g.Where(x => x.bl.PunchTypeFlag == 0)
            //                                 .Select(x => x.bl.PunchTime)
            //                                 .FirstOrDefault()
            //                                 - g.Where(x => x.bl.PunchTypeFlag == 1)
            //                                 .Select(x => x.bl.PunchTime)
            //                                 .FirstOrDefault()).TotalHours), 2),
            //            HourlySalary = g.Select(x => x.emp.HourlySalary).FirstOrDefault()
            //        })
            //        .ToList();

            //    // Calculate total salary for report footer
            //    decimal totalSalary = attendanceData.Sum(x => x.TotalSalary);
            //    //string totalSalaryInWords = ConvertToWords((int)totalSalary);

            //    reportViewer1.LocalReport.ReportPath = "ReportDummy01.rdlc";
            //    reportViewer1.LocalReport.DataSources.Clear();

            //    ReportDataSource rds = new ReportDataSource("DataSetEmployeeSqlite", attendanceData);
            //    reportViewer1.LocalReport.DataSources.Add(rds);

            //    ReportParameter totalSalaryParam = new ReportParameter("TotalSalary", totalSalary.ToString("F2"));
            //    //ReportParameter totalSalaryWordsParam = new ReportParameter("TotalSalaryInWords", totalSalaryInWords);
            //    //reportViewer1.LocalReport.SetParameters(new ReportParameter[] { totalSalaryParam, totalSalaryWordsParam });
            //    reportViewer1.LocalReport.SetParameters(new ReportParameter[] { totalSalaryParam});

            //    reportViewer1.RefreshReport();
            //}
        }

        private void FormReportViewer_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        public string ConvertToWords(int number)
        {
            if (number == 0) return "Zero";
            string[] units = { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            string[] teens = { "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            string[] tens = { "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

            string words = "";

            if (number >= 1000)
            {
                words += units[number / 1000 - 1] + " Thousand ";
                number %= 1000;
            }
            if (number >= 100)
            {
                words += units[number / 100 - 1] + " Hundred ";
                number %= 100;
            }
            if (number >= 20)
            {
                words += tens[number / 10 - 1] + " ";
                number %= 10;
            }
            else if (number > 10 && number < 20)
            {
                words += teens[number - 11] + " ";
                number = 0;
            }
            if (number > 0)
            {
                words += units[number - 1] + " ";
            }

            return words.Trim();
        }

    }
}
