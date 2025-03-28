using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Reporting.WinForms;

namespace EmpAttendanceSQLite.Reports
{
    public class ReportItem
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public decimal Total => Price * Qty;
    }

    class Report
    {
        public static void Load(LocalReport report)
        {
            var items = new[] { new ReportItem { Description = "Widget 6000", Price = 104.99m, Qty = 1 }, new ReportItem { Description = "Gizmo MAX", Price = 1.41m, Qty = 25 } };
            var parameters = new[] { new ReportParameter("Title", "Invoice 4/2020") };

            // Report locationmanage in system
            using var fs = new FileStream("Report1.rdlc", FileMode.Open);

            report.LoadReportDefinition(fs);
            report.DataSources.Add(new ReportDataSource("DataSet1", items));
            report.SetParameters(parameters);
        }
    }
}
