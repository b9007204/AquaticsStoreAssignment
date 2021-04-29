using Microsoft.EntityFrameworkCore.Migrations;

namespace AquaticsStoreAssignment.Data.Migrations
{
    public partial class AccessoriesMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accessory",
                columns: table => new
                {
                    AccessoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccessoryType = table.Column<string>(nullable: true),
                    AccessoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accessory", x => x.AccessoryID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accessory");
        }
    }
}
