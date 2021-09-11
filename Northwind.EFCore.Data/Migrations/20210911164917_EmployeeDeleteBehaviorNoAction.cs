using Microsoft.EntityFrameworkCore.Migrations;

namespace Northwind.EFCore.Data.Migrations
{
    public partial class EmployeeDeleteBehaviorNoAction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Manager",
                table: "Employees");

            migrationBuilder.AddForeignKey(
                name: "FK_Manager",
                table: "Employees",
                column: "ReportsTo",
                principalTable: "Employees",
                principalColumn: "EmployeeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Manager",
                table: "Employees");

            migrationBuilder.AddForeignKey(
                name: "FK_Manager",
                table: "Employees",
                column: "ReportsTo",
                principalTable: "Employees",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
