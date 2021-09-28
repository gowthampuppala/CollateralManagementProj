using Microsoft.EntityFrameworkCore.Migrations;

namespace CollateralManagement.Migrations
{
    public partial class UnitValueRename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InitialValue",
                table: "collateral",
                newName: "unitValue");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "unitValue",
                table: "collateral",
                newName: "InitialValue");
        }
    }
}
