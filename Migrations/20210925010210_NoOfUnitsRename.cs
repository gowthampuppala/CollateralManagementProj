using Microsoft.EntityFrameworkCore.Migrations;

namespace CollateralManagement.Migrations
{
    public partial class NoOfUnitsRename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CurrentValue",
                table: "collateral",
                newName: "NoOfUnits");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NoOfUnits",
                table: "collateral",
                newName: "CurrentValue");
        }
    }
}
