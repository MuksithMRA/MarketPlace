using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketPlace.Migrations {
public partial class brand_table : Migration {
    protected override void Up(MigrationBuilder migrationBuilder) {
        migrationBuilder
        .CreateTable(
            name: "Brand",
            columns: table =>
        new {
            id = table.Column<int>(type: "int", nullable: false)
                 .Annotation(
                     "MySql:ValueGenerationStrategy",
                     MySqlValueGenerationStrategy.IdentityColumn),
                 title =
                     table
                     .Column<string>(type: "varchar(255)",
                                     maxLength: 255, nullable: false)
                     .Annotation("MySql:CharSet", "utf8mb4"),
                     description =
                         table
                         .Column<string>(type: "longtext", nullable: false)
                         .Annotation("MySql:CharSet", "utf8mb4"),
                         image =
                             table
                             .Column<string>(type: "varchar(255)",
                                             maxLength: 255, nullable: false)
                             .Annotation("MySql:CharSet", "utf8mb4")
        },
        constraints: table => {
            table.PrimaryKey("PK_Brand", x => x.id);
        })
        .Annotation("MySql:CharSet", "utf8mb4");
    }

    protected override void Down(MigrationBuilder migrationBuilder) {
        migrationBuilder.DropTable(name: "Brand");
    }
}
}
