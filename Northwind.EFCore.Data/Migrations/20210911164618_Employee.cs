using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Northwind.EFCore.Data.Migrations
{
    public partial class Employee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "INT(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    LastName = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    FirstName = table.Column<string>(type: "VARCHAR(10)", nullable: false),
                    Title = table.Column<string>(type: "VARCHAR(30)", nullable: true),
                    TitleOfCourtesy = table.Column<string>(type: "VARCHAR(25)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    HireDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    Address = table.Column<string>(type: "VARCHAR(60)", nullable: false),
                    City = table.Column<string>(type: "VARCHAR(15)", nullable: false),
                    Region = table.Column<string>(type: "VARCHAR(15)", nullable: false),
                    PostalCode = table.Column<string>(type: "VARCHAR(10)", nullable: false),
                    Country = table.Column<string>(type: "VARCHAR(15)", nullable: false),
                    HomePhone = table.Column<string>(type: "VARCHAR(24)", nullable: true),
                    Extension = table.Column<string>(type: "VARCHAR(4)", nullable: true),
                    Notes = table.Column<string>(type: "MEDIUMTEXT", nullable: false),
                    ReportsTo = table.Column<int>(type: "INT(11)", nullable: true),
                    PhotoPath = table.Column<string>(type: "VARCHAR(255)", nullable: false),
                    Salary = table.Column<float>(type: "FLOAT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                    table.ForeignKey(
                        name: "FK_Manager",
                        column: x => x.ReportsTo,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ReportsTo",
                table: "Employees",
                column: "ReportsTo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
