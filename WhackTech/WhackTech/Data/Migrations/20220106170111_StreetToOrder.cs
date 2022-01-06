using Microsoft.EntityFrameworkCore.Migrations;

namespace WhackTech.Data.Migrations
{
    public partial class StreetToOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Canton",
                table: "Orders",
                newName: "Street");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Street",
                table: "Orders",
                newName: "Canton");
        }
    }
}
