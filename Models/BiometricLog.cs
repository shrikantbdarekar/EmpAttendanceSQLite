using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmpAttendanceSQLite.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EmpAttendanceSQLite.Models
{
    public class BiometricLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LogId { get; set; }  // Primary Key (Auto-increment)

        [Required]
        public int BMEmployeeId { get; set; }  // Biometric Employee ID

        [Required]
        public DateTime PunchTime { get; set; }  // Date and Time of Scan

        [Required]
        public int DeviceId { get; set; }  // Biometric Device ID

        [Required]
        public byte PunchTypeFlag { get; set; }  // 0 = IN, 1 = OUT

        [Required]
        public byte VerificationMode { get; set; }  // 1 = Fingerprint, 2 = Card, etc.

        [Required]
        public byte StatusCode { get; set; }  // 0 = Success, 1 = Failure, etc.

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Record Created Time
    }
}
