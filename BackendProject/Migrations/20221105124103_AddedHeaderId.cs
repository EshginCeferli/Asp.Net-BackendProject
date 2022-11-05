using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendProject.Migrations
{
    public partial class AddedHeaderId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_ProductHeaderId",
                table: "Products");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductHeaderId",
                table: "Products",
                column: "ProductHeaderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_ProductHeaderId",
                table: "Products");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductHeaderId",
                table: "Products",
                column: "ProductHeaderId",
                unique: true);
        }
    }
}
