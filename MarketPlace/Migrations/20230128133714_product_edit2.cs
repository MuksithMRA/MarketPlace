using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketPlace.Migrations
{
    public partial class product_edit2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImage_Products_product_id1",
                table: "ProductImage");

            migrationBuilder.DropIndex(
                name: "IX_ProductImage_product_id1",
                table: "ProductImage");

            migrationBuilder.DropColumn(
                name: "product_id1",
                table: "ProductImage");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImage_product_id",
                table: "ProductImage",
                column: "product_id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImage_Products_product_id",
                table: "ProductImage",
                column: "product_id",
                principalTable: "Products",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImage_Products_product_id",
                table: "ProductImage");

            migrationBuilder.DropIndex(
                name: "IX_ProductImage_product_id",
                table: "ProductImage");

            migrationBuilder.AddColumn<int>(
                name: "product_id1",
                table: "ProductImage",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProductImage_product_id1",
                table: "ProductImage",
                column: "product_id1");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImage_Products_product_id1",
                table: "ProductImage",
                column: "product_id1",
                principalTable: "Products",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
