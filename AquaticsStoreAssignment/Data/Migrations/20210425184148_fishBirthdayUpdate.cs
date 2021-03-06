using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AquaticsStoreAssignment.Data.Migrations
{
    public partial class fishBirthdayUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FishBirthday",
                table: "Fish",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FishBirthday",
                table: "Fish");
        }
    }
}
