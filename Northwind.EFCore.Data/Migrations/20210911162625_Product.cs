using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Northwind.EFCore.Data.Migrations
{
    public partial class Product : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "INT(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ProductName = table.Column<string>(type: "VARCHAR(40)", nullable: false),
                    SupplierID = table.Column<int>(type: "INT(11)", nullable: false),
                    CategoryID = table.Column<int>(type: "INT(11)", nullable: false),
                    QuantityPerUnit = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "DECIMAL(10, 4)", nullable: false),
                    UnitsInStock = table.Column<short>(type: "SMALLINT(2)", nullable: false),
                    UnitsOnOrder = table.Column<short>(type: "SMALLINT(2)", nullable: false),
                    ReorderLevel = table.Column<short>(type: "SMALLINT(2)", nullable: false),
                    Discontinued = table.Column<ulong>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Category",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Supplier",
                        column: x => x.SupplierID,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupplierID",
                table: "Products",
                column: "SupplierID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
