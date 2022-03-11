using Microsoft.EntityFrameworkCore.Migrations;

namespace _100DerseCore.Migrations
{
    public partial class CreatedStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Categories",
                newName: "CategoryStatus");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CategoryStatus",
                table: "Categories",
                newName: "Status");
        }
    }
}
