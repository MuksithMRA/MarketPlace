using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketPlace.Migrations {
public partial class sub_category_table_added1 : Migration {
    protected override void Up(MigrationBuilder migrationBuilder) {
        migrationBuilder.CreateTable(
            name: "Sub_Category",
            columns: table => new
        {
            id = table.Column<int>(type: "int", nullable: false)
                 .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                 title = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                         .Annotation("MySql:CharSet", "utf8mb4"),
                         description = table.Column<string>(type: "longtext", nullable: false)
                                       .Annotation("MySql:CharSet", "utf8mb4"),
                                       image = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                                               .Annotation("MySql:CharSet", "utf8mb4"),
                                               brand_id = table.Column<int>(type: "int", nullable: false)
        },
        constraints: table =>
        {
            table.PrimaryKey("PK_Sub_Category", x => x.id);
            table.ForeignKey(
                name: "FK_Sub_Category_Brand_brand_id",
                column: x => x.brand_id,
                principalTable: "Brand",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        })
        .Annotation("MySql:CharSet", "utf8mb4");

        migrationBuilder.CreateIndex(name: "IX_Sub_Category_brand_id",
                                     table: "Sub_Category", column: "brand_id");
    }

    protected override void Down(MigrationBuilder migrationBuilder) {
        migrationBuilder.DropTable(name: "Sub_Category");
    }
}
}
