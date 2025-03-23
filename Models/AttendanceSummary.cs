using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpAttendanceSQLite.Models
{
    class AttendanceSummary
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SummaryId { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        [Required]
        public DateTime WorkDate { get; set; }

        public decimal? TotalHours { get; set; } // NULL if missing entry

        public bool MissingEntry { get; set; } // True if IN or OUT is missing

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }
}
