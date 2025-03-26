using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmpAttendanceSQLite.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BiometricLogs",
                columns: table => new
                {
                    LogId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BMEmployeeId = table.Column<int>(type: "INTEGER", nullable: false),
                    PunchTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DeviceId = table.Column<int>(type: "INTEGER", nullable: false),
                    PunchTypeFlag = table.Column<int>(type: "INTEGER", nullable: false),
                    VerificationMode = table.Column<int>(type: "INTEGER", nullable: false),
                    StatusCode = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    RecordType = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    BatchCode = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    InOut = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    ManualEntryRemark = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BiometricLogs", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "BiometricMachines",
                columns: table => new
                {
                    MachineId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BMMachineId = table.Column<int>(type: "INTEGER", nullable: false),
                    MachineName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    MachineDescription = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BiometricMachines", x => x.MachineId);
                });

            migrationBuilder.CreateTable(
                name: "CompanyInfos",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CompanyName = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    CompanyAddress = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    EmailId = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    ContactNo = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    Website = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ShiftStart = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    ShiftEnd = table.Column<TimeSpan>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyInfos", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmployeeCode = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    BMEmployeeId = table.Column<int>(type: "INTEGER", nullable: false),
                    JoiningDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EmployeeName = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Address = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    EmailId = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    ContactNumber1 = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    ContactNumber2 = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    Department = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Designation = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    MonthlySalary = table.Column<decimal>(type: "DECIMAL(10,2)", nullable: false),
                    HourlySalary = table.Column<decimal>(type: "DECIMAL(10,2)", nullable: false),
                    ShiftStart = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    ShiftEnd = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "LoginUsers",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: false),
                    Role = table.Column<int>(type: "INTEGER", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginUsers", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "MissingLogs",
                columns: table => new
                {
                    MissingLogId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BMEmployeeId = table.Column<int>(type: "INTEGER", nullable: false),
                    PunchDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    MissingType = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    BatchCode = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MissingLogs", x => x.MissingLogId);
                });

            migrationBuilder.InsertData(
                table: "CompanyInfos",
                columns: new[] { "CompanyId", "CompanyAddress", "CompanyName", "ContactNo", "CreatedAt", "EmailId", "ShiftEnd", "ShiftStart", "Website" },
                values: new object[] { 1, "123, Tech Park, Mumbai", "ABC Pvt Ltd", "+91-9876543210", new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "contact@abc.com", new TimeSpan(0, 20, 0, 0, 0), new TimeSpan(0, 8, 30, 0, 0), "https://www.abc.com" });

            migrationBuilder.InsertData(
                table: "LoginUsers",
                columns: new[] { "UserId", "CreatedAt", "IsActive", "PasswordHash", "Role", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "sadmin", 1, "sadmin" },
                    { 2, new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "admin", 2, "admin" },
                    { 3, new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "emp", 3, "emp" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BiometricLogs");

            migrationBuilder.DropTable(
                name: "BiometricMachines");

            migrationBuilder.DropTable(
                name: "CompanyInfos");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "LoginUsers");

            migrationBuilder.DropTable(
                name: "MissingLogs");
        }
    }
}
