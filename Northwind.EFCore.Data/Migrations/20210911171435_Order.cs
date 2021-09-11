using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Northwind.EFCore.Data.Migrations
{
    public partial class Order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "INT(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CustomerID = table.Column<string>(type: "VARCHAR(5)", nullable: false),
                    EmployeeID = table.Column<int>(type: "INT(11)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    RequiredDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    ShippedDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    ShipVia = table.Column<int>(type: "INT(11)", nullable: false),
                    Freight = table.Column<decimal>(type: "DECIMAL(10, 4)", nullable: false),
                    ShipName = table.Column<string>(type: "VARCHAR(40)", nullable: false),
                    ShipAddress = table.Column<string>(type: "VARCHAR(60)", nullable: false),
                    ShipCity = table.Column<string>(type: "VARCHAR(15)", nullable: false),
                    ShipRegion = table.Column<string>(type: "VARCHAR(15)", nullable: false),
                    ShipPostalCode = table.Column<string>(type: "VARCHAR(10)", nullable: false),
                    ShipCountry = table.Column<string>(type: "VARCHAR(15)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Customer",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID");
                    table.ForeignKey(
                        name: "FK_Employee",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID");
                    table.ForeignKey(
                        name: "FK_Shipper",
                        column: x => x.ShipVia,
                        principalTable: "Shippers",
                        principalColumn: "ShipperID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_EmployeeID",
                table: "Orders",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ShipVia",
                table: "Orders",
                column: "ShipVia");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
