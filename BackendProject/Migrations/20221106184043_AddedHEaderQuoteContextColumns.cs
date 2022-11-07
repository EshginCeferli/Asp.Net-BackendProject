using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendProject.Migrations
{
    public partial class AddedHEaderQuoteContextColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ArticleContext",
                table: "Blogs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ArticleHeader",
                table: "Blogs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ArticleQuote",
                table: "Blogs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArticleContext",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "ArticleHeader",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "ArticleQuote",
                table: "Blogs");
        }
    }
}
