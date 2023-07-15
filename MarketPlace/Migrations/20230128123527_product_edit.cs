using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketPlace.Migrations {
public partial class product_edit : Migration {
  protected override void Up(MigrationBuilder migrationBuilder) {
    migrationBuilder.DropForeignKey(name: "FK_Products_Category_category_id1",
                                    table: "Products");

    migrationBuilder.DropForeignKey(name: "FK_Products_Stores_store_id1",
                                    table: "Products");

    migrationBuilder.DropForeignKey(
        name: "FK_Products_Sub_Category_sub_category_id1", table: "Products");

    migrationBuilder.DropIndex(name: "IX_Products_category_id1",
                               table: "Products");

    migrationBuilder.DropIndex(name: "IX_Products_store_id1",
                               table: "Products");

    migrationBuilder.DropIndex(name: "IX_Products_sub_category_id1",
                               table: "Products");

    migrationBuilder.DropColumn(name: "category_id1", table: "Products");

    migrationBuilder.DropColumn(name: "store_id1", table: "Products");

    migrationBuilder.DropColumn(name: "sub_category_id1", table: "Products");

    migrationBuilder.CreateIndex(name: "IX_Products_category_id",
                                 table: "Products", column: "category_id");

    migrationBuilder.CreateIndex(name: "IX_Products_store_id",
                                 table: "Products", column: "store_id");

    migrationBuilder.CreateIndex(name: "IX_Products_sub_category_id",
                                 table: "Products", column: "sub_category_id");

    migrationBuilder.AddForeignKey(
        name: "FK_Products_Category_category_id", table: "Products",
        column: "category_id", principalTable: "Category",
        principalColumn: "id", onDelete: ReferentialAction.Cascade);

    migrationBuilder.AddForeignKey(
        name: "FK_Products_Stores_store_id", table: "Products",
        column: "store_id", principalTable: "Stores", principalColumn: "id",
        onDelete: ReferentialAction.Cascade);

    migrationBuilder.AddForeignKey(
        name: "FK_Products_Sub_Category_sub_category_id", table: "Products",
        column: "sub_category_id", principalTable: "Sub_Category",
        principalColumn: "id", onDelete: ReferentialAction.Cascade);
  }

  protected override void Down(MigrationBuilder migrationBuilder) {
    migrationBuilder.DropForeignKey(name: "FK_Products_Category_category_id",
                                    table: "Products");

    migrationBuilder.DropForeignKey(name: "FK_Products_Stores_store_id",
                                    table: "Products");

    migrationBuilder.DropForeignKey(
        name: "FK_Products_Sub_Category_sub_category_id", table: "Products");

    migrationBuilder.DropIndex(name: "IX_Products_category_id",
                               table: "Products");

    migrationBuilder.DropIndex(name: "IX_Products_store_id", table: "Products");

    migrationBuilder.DropIndex(name: "IX_Products_sub_category_id",
                               table: "Products");

    migrationBuilder.AddColumn<int>(name: "category_id1", table: "Products",
                                    type: "int", nullable: false,
                                    defaultValue: 0);

    migrationBuilder.AddColumn<int>(name: "store_id1", table: "Products",
                                    type: "int", nullable: false,
                                    defaultValue: 0);

    migrationBuilder.AddColumn<int>(name: "sub_category_id1", table: "Products",
                                    type: "int", nullable: false,
                                    defaultValue: 0);

    migrationBuilder.CreateIndex(name: "IX_Products_category_id1",
                                 table: "Products", column: "category_id1");

    migrationBuilder.CreateIndex(name: "IX_Products_store_id1",
                                 table: "Products", column: "store_id1");

    migrationBuilder.CreateIndex(name: "IX_Products_sub_category_id1",
                                 table: "Products", column: "sub_category_id1");

    migrationBuilder.AddForeignKey(
        name: "FK_Products_Category_category_id1", table: "Products",
        column: "category_id1", principalTable: "Category",
        principalColumn: "id", onDelete: ReferentialAction.Cascade);

    migrationBuilder.AddForeignKey(
        name: "FK_Products_Stores_store_id1", table: "Products",
        column: "store_id1", principalTable: "Stores", principalColumn: "id",
        onDelete: ReferentialAction.Cascade);

    migrationBuilder.AddForeignKey(
        name: "FK_Products_Sub_Category_sub_category_id1", table: "Products",
        column: "sub_category_id1", principalTable: "Sub_Category",
        principalColumn: "id", onDelete: ReferentialAction.Cascade);
  }
}
}
