using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpAttendanceSQLite.Models
{
    public class LoginUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Required]
        [MaxLength(255)]
        public string UserName { get; set; } // Login Username

        [Required]
        public string PasswordHash { get; set; } // Hashed Password

        [Required]
        public int Role { get; set; } // "Admin", "HR", "Employee"

        public bool IsActive { get; set; } = true; // Account status

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
