using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendProject.Migrations
{
    public partial class addedBlogTable : Migration
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

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    By = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.AddColumn<int>(
                name: "ProductHeaderId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                onDelete: ReferentialAction.Cascade);
        }
    }
}
