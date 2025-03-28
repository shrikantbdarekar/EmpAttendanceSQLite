using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpAttendanceSQLite.Models
{
    public class EmployeeAttendanceReportModel
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public DateTime PunchDate { get; set; }
        public TimeSpan? InTime { get; set; }
        public TimeSpan? OutTime { get; set; }
        public decimal TotalHours { get; set; }
        public decimal HourlySalary { get; set; }
        public decimal TotalSalary => TotalHours * HourlySalary;
    }
}
