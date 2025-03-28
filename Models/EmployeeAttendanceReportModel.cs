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
        public int BMEmployeeId { get; set; }
        public DateTime PunchDate { get; set; }
        public DateTime In { get; set; }
        public DateTime Out { get; set; }
        public double TotalHours { get; set; }
        public double HourlySalary { get; set; }
        public double TotalSalary => TotalHours * HourlySalary;

        //public int BMEmployeeId { get; set; } // Biometric Employee ID
        //public string EmployeeName { get; set; } // Employee Name
        //public int EmployeeId { get; set; } // Employee ID
        //public DateTime PunchDate { get; set; } // Date of Punch
        //public DateTime? IN { get; set; } // First IN Punch
        //public DateTime? OUT { get; set; } // Last OUT Punch
        //public double TotalHours { get; set; } // Total Hours Worked
    }
}
