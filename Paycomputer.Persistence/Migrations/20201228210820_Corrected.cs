using Microsoft.EntityFrameworkCore.Migrations;

namespace Paycomputer.Persistence.Migrations
{
    public partial class Corrected : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OvertimeHourds",
                table: "PaymentRecords",
                newName: "OvertimeHours");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OvertimeHours",
                table: "PaymentRecords",
                newName: "OvertimeHourds");
        }
    }
}
