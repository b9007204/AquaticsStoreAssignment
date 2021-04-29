using Microsoft.EntityFrameworkCore.Migrations;

namespace AquaticsStoreAssignment.Data.Migrations
{
    public partial class initialSetupTank : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tank",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TankName = table.Column<string>(nullable: true),
                    Volume = table.Column<string>(nullable: true),
                    Filter = table.Column<string>(nullable: true),
                    Heater = table.Column<string>(nullable: true),
                    Lighting = table.Column<string>(nullable: true),
                    Dimensions = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tank", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tank");
        }
    }
}
