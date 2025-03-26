using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmpAttendanceSQLite.Models;

namespace EmpAttendanceSQLite.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<CompanyInfo> CompanyInfos { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<BiometricMachine> BiometricMachines { get; set; }
        public DbSet<LoginUser> LoginUsers { get; set; }
        public DbSet<BiometricLog> BiometricLogs { get; set; }

        public DbSet<MissingLog> MissingLogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=EmpAttendanceDB.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var defaultCompanyInfo = new List<CompanyInfo>
            {
                new CompanyInfo
                {
                    CompanyId = 1,
                    CompanyName = "ABC Pvt Ltd",
                    CompanyAddress = "123, Tech Park, Mumbai",
                    EmailId = "contact@abc.com",
                    ContactNo = "+91-9876543210",
                    Website = "https://www.abc.com",
                    CreatedAt = new DateTime(2025, 3, 24, 0, 0, 0), // Hardcoded DateTime >> DateTime.UtcNow
                    ShiftStart = new TimeSpan(8,30,0),
                    ShiftEnd = new TimeSpan(18,0,0)
                }
            };
            modelBuilder.Entity<CompanyInfo>().HasData(defaultCompanyInfo);


            var defaultLoginUsers = new List<LoginUser>
            {
                new LoginUser
                {
                    UserId = 1,
                    UserName= "sadmin",
                    PasswordHash= "sadmin",
                    Role=1,
                    IsActive=true,
                    CreatedAt = new DateTime(2025, 3, 24, 0, 0, 0) // Hardcoded DateTime
                },
                new LoginUser
                {
                    UserId = 2,
                    UserName= "admin",
                    PasswordHash= "admin",
                    Role=2,
                    IsActive=true,
                    CreatedAt = new DateTime(2025, 3, 24, 0, 0, 0) // Hardcoded DateTime
                },
                new LoginUser
                {
                    UserId = 3,
                    UserName= "emp",
                    PasswordHash= "emp",
                    Role=3,
                    IsActive=true,
                    CreatedAt = new DateTime(2025, 3, 24, 0, 0, 0) // Hardcoded DateTime
                }
            };

            modelBuilder.Entity<LoginUser>().HasData(defaultLoginUsers);

        }
    }
}
