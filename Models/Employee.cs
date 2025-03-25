using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpAttendanceSQLite.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }  // Primary Key (Auto-increment)

        [Required]
        [MaxLength(20)]
        public string EmployeeCode { get; set; }  // Employee Code

        [Required]
        public int BMEmployeeId { get; set; }  // Biometric Employee ID

        [Required]
        public DateTime JoiningDate { get; set; }  // Employee JoiningDate

        [Required]
        public DateTime BirthDate { get; set; }  // Employee Birthdate

        [Required]
        [MaxLength(200)]
        public string EmployeeName { get; set; }  // Employee Name

        [MaxLength(255)]
        public string Address { get; set; }  // Employee Address

        [MaxLength(100)]
        [EmailAddress]
        public string EmailId { get; set; }  // Employee Email

        [Required]
        [MaxLength(15)]
        public string ContactNumber1 { get; set; }  // Primary Contact Number

        [MaxLength(15)]
        public string ContactNumber2 { get; set; }  // Secondary Contact Number (Optional)

        [MaxLength(100)]
        public string Department { get; set; }  // Employee Department

        [MaxLength(100)]
        public string Designation { get; set; }  // Employee Designation

        [Required]
        [Column(TypeName = "DECIMAL(10,2)")]
        public decimal MonthlySalary { get; set; }  // Fixed Monthly Salary

        [Required]
        [Column(TypeName = "DECIMAL(10,2)")]
        public decimal HourlySalary { get; set; }   // Hourly Salary

        [Required]
        public TimeSpan ShiftStart { get; set; }  // Employee Shift Start Time

        [Required]
        public TimeSpan ShiftEnd { get; set; }  // Employee Shift End Time

        [Required]
        public bool IsActive { get; set; }  // Employee Active/Inactive Status

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Record Created Time
    }
}
