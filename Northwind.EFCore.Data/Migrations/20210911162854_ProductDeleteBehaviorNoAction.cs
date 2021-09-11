using Microsoft.EntityFrameworkCore.Migrations;

namespace Northwind.EFCore.Data.Migrations
{
    public partial class ProductDeleteBehaviorNoAction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Supplier",
                table: "Products");

            migrationBuilder.AddForeignKey(
                name: "FK_Category",
                table: "Products",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Supplier",
                table: "Products",
                column: "SupplierID",
                principalTable: "Suppliers",
                principalColumn: "SupplierID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Supplier",
                table: "Products");

            migrationBuilder.AddForeignKey(
                name: "FK_Category",
                table: "Products",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Supplier",
                table: "Products",
                column: "SupplierID",
                principalTable: "Suppliers",
                principalColumn: "SupplierID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
