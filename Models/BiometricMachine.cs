using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EmpAttendanceSQLite.Models
{
    public class BiometricMachine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MachineId { get; set; }  // Primary Key (Auto-increment)

        [Required]
        public int BMMachineId { get; set; }  // Biometric Machine Id

        [Required]
        [MaxLength(100)]
        public string MachineName { get; set; }  // Machine Name

        [Required]
        [MaxLength(150)]
        public string MachineDescription { get; set; }  // Location Name

        [Required]
        public bool IsActive { get; set; }  // Employee Active/Inactive Status

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Record Created Time
    }
}
