using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Northwind.EFCore.Data.Migrations
{
    public partial class Supplier : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    SupplierID = table.Column<int>(type: "INT(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CompanyName = table.Column<string>(type: "VARCHAR(40)", nullable: false),
                    ContactName = table.Column<string>(type: "VARCHAR(30)", nullable: true),
                    ContactTitle = table.Column<string>(type: "VARCHAR(30)", nullable: true),
                    Address = table.Column<string>(type: "VARCHAR(60)", nullable: false),
                    City = table.Column<string>(type: "VARCHAR(15)", nullable: false),
                    Region = table.Column<string>(type: "VARCHAR(15)", nullable: false),
                    PostalCode = table.Column<string>(type: "VARCHAR(10)", nullable: false),
                    Country = table.Column<string>(type: "VARCHAR(15)", nullable: false),
                    Phone = table.Column<string>(type: "VARCHAR(24)", nullable: false),
                    Fax = table.Column<string>(type: "VARCHAR(24)", nullable: true),
                    HomePage = table.Column<string>(type: "MEDIUMTEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.SupplierID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
