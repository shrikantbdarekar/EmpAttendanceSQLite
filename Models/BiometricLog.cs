using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmpAttendanceSQLite.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using EmpAttendanceSQLite.Data;

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
        public int PunchTypeFlag { get; set; }  // 0 = IN, 1 = OUT

        [Required]
        public int VerificationMode { get; set; }  // 1 = Fingerprint, 2 = Card, etc.

        [Required]
        public int StatusCode { get; set; }  // 0 = Success, 1 = Failure, etc.

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Record Created Time

        [Required]
        [MaxLength(10)]
        public string RecordType { get; set; } = RecordTypes.NONE.ToString(); // MANL = Inserted manually, AUTO = Imported from backup file,

        [Required]
        [MaxLength(20)]
        public string BatchCode { get; set; } // BC-YYYYMMDDHHMMSS
    }
}
