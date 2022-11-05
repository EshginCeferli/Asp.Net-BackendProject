using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendProject.Migrations
{
    public partial class addedProductHeaderTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "productHeaderId",
                table: "Products",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductHeaders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Header = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductHeaders", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_productHeaderId",
                table: "Products",
                column: "productHeaderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductHeaders_productHeaderId",
                table: "Products",
                column: "productHeaderId",
                principalTable: "ProductHeaders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductHeaders_productHeaderId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ProductHeaders");

            migrationBuilder.DropIndex(
                name: "IX_Products_productHeaderId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "productHeaderId",
                table: "Products");
        }
    }
}
