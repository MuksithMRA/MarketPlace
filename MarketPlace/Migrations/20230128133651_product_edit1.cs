using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketPlace.Migrations
{
public partial class product_edit1 : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "ProductImage",
            columns: table => new
        {
            id = table.Column<int>(type: "int", nullable: false)
                 .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                 image = table.Column<string>(type: "longtext", nullable: false)
                         .Annotation("MySql:CharSet", "utf8mb4"),
                         product_id = table.Column<int>(type: "int", nullable: false),
                         product_id1 = table.Column<int>(type: "int", nullable: false)
        },
        constraints: table =>
        {
            table.PrimaryKey("PK_ProductImage", x => x.id);
            table.ForeignKey(
                name: "FK_ProductImage_Products_product_id1",
                column: x => x.product_id1,
                principalTable: "Products",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        })
        .Annotation("MySql:CharSet", "utf8mb4");

        migrationBuilder.CreateIndex(
            name: "IX_ProductImage_product_id1",
            table: "ProductImage",
            column: "product_id1");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "ProductImage");
    }
}
}
