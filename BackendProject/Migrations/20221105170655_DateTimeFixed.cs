using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendProject.Migrations
{
    public partial class DateTimeFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductHeaders_ProductHeaderId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductHeaderId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductHeaderId",
                table: "Products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductHeaderId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductHeaderId",
                table: "Products",
                column: "ProductHeaderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductHeaders_ProductHeaderId",
                table: "Products",
                column: "ProductHeaderId",
                principalTable: "ProductHeaders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
