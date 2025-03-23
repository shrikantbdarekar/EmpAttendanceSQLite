using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpAttendanceSQLite.Models
{
    public class CompanyInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CompanyId { get; set; }

        [Required]
        [MaxLength(255)]
        public string CompanyName { get; set; } 

        [Required]
        [MaxLength(255)]
        public string CompanyAddress { get; set; } 

        [Required]
        [MaxLength(150)]
        public string EmailId { get; set; }

        [Required]
        [MaxLength(150)]
        public string ContactNo { get; set; }

        [Required]
        [MaxLength(150)]
        public string Website { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
