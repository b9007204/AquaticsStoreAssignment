using Microsoft.EntityFrameworkCore.Migrations;

namespace AquaticsStoreAssignment.Data.Migrations
{
    public partial class initialsetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fish",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    FishName = table.Column<string>(nullable: true),
                    HabitatType = table.Column<string>(nullable: true),
                    Temperament = table.Column<string>(nullable: true),
                    AverageSize = table.Column<string>(nullable: true),
                    MinimumTankSize = table.Column<string>(nullable: true),
                    Diet = table.Column<string>(nullable: true),
                    Lifespan = table.Column<string>(nullable: true),
                    Availability = table.Column<string>(nullable: true)
                    
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fish", x => x.ID);
                });;
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fish");
        }
    }
}
