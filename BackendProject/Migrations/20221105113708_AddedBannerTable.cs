using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendProject.Migrations
{
    public partial class AddedBannerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductHeaders_productHeaderId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_productHeaderId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "productHeaderId",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "Banners",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Subtitle = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banners", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Banners");

            migrationBuilder.AddColumn<int>(
                name: "productHeaderId",
                table: "Products",
                type: "int",
                nullable: true);

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
    }
}
