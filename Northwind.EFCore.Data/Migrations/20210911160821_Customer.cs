using Microsoft.EntityFrameworkCore.Migrations;

namespace Northwind.EFCore.Data.Migrations
{
    public partial class Customer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<string>(type: "VARCHAR(5)", nullable: false),
                    CompanyName = table.Column<string>(type: "VARCHAR(40)", nullable: false),
                    ContactName = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    ContactTitle = table.Column<string>(type: "VARCHAR(30)", nullable: true),
                    Address = table.Column<string>(type: "VARCHAR(60)", nullable: false),
                    City = table.Column<string>(type: "VARCHAR(15)", nullable: false),
                    Region = table.Column<string>(type: "VARCHAR(15)", nullable: false),
                    PostalCode = table.Column<string>(type: "VARCHAR(10)", nullable: false),
                    Country = table.Column<string>(type: "VARCHAR(15)", nullable: false),
                    Phone = table.Column<string>(type: "VARCHAR(24)", nullable: false),
                    Fax = table.Column<string>(type: "VARCHAR(24)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CustomerID",
                table: "Customers",
                column: "CustomerID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
