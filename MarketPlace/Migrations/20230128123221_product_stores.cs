using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketPlace.Migrations {
public partial class product_stores : Migration {
  protected override void Up(MigrationBuilder migrationBuilder) {
    migrationBuilder.DropForeignKey(name: "FK_Sub_Category_Category_CategoryId",
                                    table: "Sub_Category");

    migrationBuilder.RenameColumn(name: "title", table: "Sub_Category",
                                  newName: "name");

    migrationBuilder.RenameColumn(name: "CategoryId", table: "Sub_Category",
                                  newName: "category_id");

    migrationBuilder.RenameIndex(name: "IX_Sub_Category_CategoryId",
                                 table: "Sub_Category",
                                 newName: "IX_Sub_Category_category_id");

    migrationBuilder.RenameColumn(name: "title", table: "Category",
                                  newName: "name");

    migrationBuilder.RenameColumn(name: "title", table: "Brand",
                                  newName: "name");

    migrationBuilder.AlterColumn<int>(
        name: "category_id", table: "Sub_Category", type: "int",
        nullable: false, defaultValue: 0, oldClrType: typeof(int),
        oldType: "int", oldNullable: true);

    migrationBuilder.CreateTable(
            name: "Stores",
            columns: table => new
        {
            id = table.Column<int>(type: "int", nullable: false)
                 .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                 name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                        description = table.Column<string>(type: "longtext", nullable: false)
                                      .Annotation("MySql:CharSet", "utf8mb4"),
                                      image = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                                              .Annotation("MySql:CharSet", "utf8mb4"),
                                              location_id = table.Column<int>(type: "int", nullable: false)
        },
        constraints: table =>
        {
            table.PrimaryKey("PK_Stores", x => x.id);
            table.ForeignKey(
                name: "FK_Stores_Location_location_id",
                column: x => x.location_id,
                principalTable: "Location",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        })
        .Annotation("MySql:CharSet", "utf8mb4");

    migrationBuilder.CreateTable(
            name: "Products",
            columns: table => new
        {
            id = table.Column<int>(type: "int", nullable: false)
                 .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                 name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                        qty = table.Column<int>(type: "int", nullable: false),
                        description = table.Column<string>(type: "longtext", nullable: false)
                                      .Annotation("MySql:CharSet", "utf8mb4"),
                                      price = table.Column<double>(type: "double", nullable: false),
                                      thumbnail = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                                                  .Annotation("MySql:CharSet", "utf8mb4"),
                                                  shipping_fee = table.Column<double>(type: "double", nullable: false),
                                                  category_id = table.Column<int>(type: "int", nullable: false),
                                                  sub_category_id = table.Column<int>(type: "int", nullable: false),
                                                  store_id = table.Column<int>(type: "int", nullable: false),
                                                  category_id1 = table.Column<int>(type: "int", nullable: false),
                                                  sub_category_id1 = table.Column<int>(type: "int", nullable: false),
                                                  store_id1 = table.Column<int>(type: "int", nullable: false)
        },
        constraints: table =>
        {
            table.PrimaryKey("PK_Products", x => x.id);
            table.ForeignKey(
                name: "FK_Products_Category_category_id1",
                column: x => x.category_id1,
                principalTable: "Category",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
            table.ForeignKey(
                name: "FK_Products_Stores_store_id1",
                column: x => x.store_id1,
                principalTable: "Stores",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
            table.ForeignKey(
                name: "FK_Products_Sub_Category_sub_category_id1",
                column: x => x.sub_category_id1,
                principalTable: "Sub_Category",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        })
        .Annotation("MySql:CharSet", "utf8mb4");

    migrationBuilder.CreateIndex(name: "IX_Products_category_id1",
                                 table: "Products", column: "category_id1");

    migrationBuilder.CreateIndex(name: "IX_Products_store_id1",
                                 table: "Products", column: "store_id1");

    migrationBuilder.CreateIndex(name: "IX_Products_sub_category_id1",
                                 table: "Products", column: "sub_category_id1");

    migrationBuilder.CreateIndex(name: "IX_Stores_location_id", table: "Stores",
                                 column: "location_id");

    migrationBuilder.AddForeignKey(
        name: "FK_Sub_Category_Category_category_id", table: "Sub_Category",
        column: "category_id", principalTable: "Category",
        principalColumn: "id", onDelete: ReferentialAction.Cascade);
  }

  protected override void Down(MigrationBuilder migrationBuilder) {
    migrationBuilder.DropForeignKey(
        name: "FK_Sub_Category_Category_category_id", table: "Sub_Category");

    migrationBuilder.DropTable(name: "Products");

    migrationBuilder.DropTable(name: "Stores");

    migrationBuilder.RenameColumn(name: "name", table: "Sub_Category",
                                  newName: "title");

    migrationBuilder.RenameColumn(name: "category_id", table: "Sub_Category",
                                  newName: "CategoryId");

    migrationBuilder.RenameIndex(name: "IX_Sub_Category_category_id",
                                 table: "Sub_Category",
                                 newName: "IX_Sub_Category_CategoryId");

    migrationBuilder.RenameColumn(name: "name", table: "Category",
                                  newName: "title");

    migrationBuilder.RenameColumn(name: "name", table: "Brand",
                                  newName: "title");

    migrationBuilder.AlterColumn<int>(name: "CategoryId", table: "Sub_Category",
                                      type: "int", nullable: true,
                                      oldClrType: typeof(int), oldType: "int");

    migrationBuilder.AddForeignKey(name: "FK_Sub_Category_Category_CategoryId",
                                   table: "Sub_Category", column: "CategoryId",
                                   principalTable: "Category",
                                   principalColumn: "id");
  }
}
}
