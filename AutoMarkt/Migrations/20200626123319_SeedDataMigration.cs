using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoMarkt.Migrations
{
    public partial class SeedDataMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Employee_EmployeeId1",
                table: "Vehicle");

            migrationBuilder.DropIndex(
                name: "IX_Vehicle_EmployeeId1",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "EmployeeId1",
                table: "Vehicle");

            migrationBuilder.AlterColumn<string>(
                name: "Fuel",
                table: "Vehicle",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "Vehicle",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<bool>(
                name: "Approved",
                table: "Vehicle",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "Employee",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "employeeVehicle",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(nullable: false),
                    VehicleId = table.Column<int>(nullable: false),
                    employeeId = table.Column<string>(nullable: true),
                    vehicleId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employeeVehicle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_employeeVehicle_Employee_employeeId",
                        column: x => x.employeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_employeeVehicle_Vehicle_vehicleId",
                        column: x => x.vehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_employeeVehicle_employeeId",
                table: "employeeVehicle",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_employeeVehicle_vehicleId",
                table: "employeeVehicle",
                column: "vehicleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employeeVehicle");

            migrationBuilder.DropColumn(
                name: "Approved",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Employee");

            migrationBuilder.AlterColumn<int>(
                name: "Fuel",
                table: "Vehicle",
                type: "int",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "Vehicle",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId1",
                table: "Vehicle",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_EmployeeId1",
                table: "Vehicle",
                column: "EmployeeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Employee_EmployeeId1",
                table: "Vehicle",
                column: "EmployeeId1",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
