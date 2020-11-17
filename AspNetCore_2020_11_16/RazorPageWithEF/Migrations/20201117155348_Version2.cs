using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPageWithEF.Migrations
{
    public partial class Version2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StadiumSize",
                table: "FootballClub",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StadiumSize",
                table: "FootballClub");
        }
    }
}
