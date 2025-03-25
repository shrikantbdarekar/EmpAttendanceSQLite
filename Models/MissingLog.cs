using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpAttendanceSQLite.Models
{
    public class MissingLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MissingLogId { get; set; }

        [Required]
        public int BMEmployeeId { get; set; }

        [Required]
        public DateTime PunchDate { get; set; }  // Date of missing punch

        [Required]
        [MaxLength(20)]
        public string MissingType { get; set; } // "Missing IN" or "Missing OUT"

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Required]
        [MaxLength(20)]
        public string BatchCode { get; set; } = "BCODE-" + DateTime.Now.ToString("yyyyMMddhhmmss").ToString(); // BC-YYYYMMDDHHMMSS
    }
}
