using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hairdresser_Website.Migrations
{
    public partial class Appointmentdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
name: "Appointments",
columns: table => new
{
    AppointmentId = table.Column<int>(type: "int", nullable: false)
        .Annotation("SqlServer:Identity", "1, 1"),
    AppointmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
    ServiceId = table.Column<int>(type: "int", nullable: false),
    EmployeeId = table.Column<int>(type: "int", nullable: false),
    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
},
constraints: table =>
{
    table.PrimaryKey("PK_Appointments", x => x.AppointmentId);
    table.ForeignKey(
        name: "FK_Appointments_Employees_EmployeeId",
        column: x => x.EmployeeId,
        principalTable: "Employees",
        principalColumn: "EmployeeId",
        onDelete: ReferentialAction.Restrict); // تغيير إلى Restrict
    table.ForeignKey(
        name: "FK_Appointments_Services_ServiceId",
        column: x => x.ServiceId,
        principalTable: "Services",
        principalColumn: "ServiceId",
        onDelete: ReferentialAction.Restrict); // تغيير إلى Restrict
    table.ForeignKey(
        name: "FK_Appointments_Users_UserId",
        column: x => x.UserId,
        principalTable: "Users",
        principalColumn: "UserId",
        onDelete: ReferentialAction.Cascade);
});
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
              name: "Appointments");
        }
    }
}
