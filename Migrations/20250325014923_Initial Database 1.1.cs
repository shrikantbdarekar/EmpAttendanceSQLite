using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpAttendanceSQLite.Migrations
{
    /// <inheritdoc />
    public partial class InitialDatabase11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BatchCode",
                table: "MissingLogs",
                type: "TEXT",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BatchCode",
                table: "MissingLogs");
        }
    }
}
