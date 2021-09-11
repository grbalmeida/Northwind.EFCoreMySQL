using Microsoft.EntityFrameworkCore.Migrations;

namespace Northwind.EFCore.Data.Migrations
{
    public partial class Territory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Territories",
                columns: table => new
                {
                    TerritoryID = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    TerritoryDescription = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    RegionID = table.Column<int>(type: "INT(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Territories", x => x.TerritoryID);
                    table.ForeignKey(
                        name: "FK_Region",
                        column: x => x.RegionID,
                        principalTable: "Region",
                        principalColumn: "RegionID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Territories_RegionID",
                table: "Territories",
                column: "RegionID");

            migrationBuilder.CreateIndex(
                name: "IX_Territories_TerritoryDescription",
                table: "Territories",
                column: "TerritoryDescription",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Territories_TerritoryID",
                table: "Territories",
                column: "TerritoryID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Territories");
        }
    }
}
