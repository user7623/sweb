using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoMarkt.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Rank = table.Column<string>(maxLength: 50, nullable: false),
                    Wage = table.Column<int>(nullable: false),
                    Education = table.Column<string>(maxLength: 50, nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    pic = table.Column<string>(nullable: true),
                    ProfitMade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Owner",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owner", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Make = table.Column<string>(maxLength: 30, nullable: false),
                    Colour = table.Column<string>(maxLength: 30, nullable: false),
                    cc = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    EnginePower = table.Column<int>(nullable: false),
                    Weight = table.Column<decimal>(nullable: false),
                    Fuel = table.Column<int>(maxLength: 20, nullable: false),
                    ChassisNumber = table.Column<long>(nullable: false),
                    Description = table.Column<string>(maxLength: 300, nullable: false),
                    pic = table.Column<string>(nullable: true),
                    EmployeeId = table.Column<int>(nullable: false),
                    SaleDate = table.Column<DateTime>(nullable: false),
                    BuyerFullname = table.Column<string>(maxLength: 100, nullable: true),
                    buyerAddres = table.Column<string>(nullable: true),
                    BuyerPhone = table.Column<long>(nullable: false),
                    EmployeeId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicle_Employee_EmployeeId1",
                        column: x => x.EmployeeId1,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_EmployeeId1",
                table: "Vehicle",
                column: "EmployeeId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Owner");

            migrationBuilder.DropTable(
                name: "Vehicle");

            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
