using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendProject.Migrations
{
    public partial class addedColorCountColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Count",
                table: "Colors",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "Colors");
        }
    }
}
