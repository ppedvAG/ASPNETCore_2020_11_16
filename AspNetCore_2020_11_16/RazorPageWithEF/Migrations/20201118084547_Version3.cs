using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPageWithEF.Migrations
{
    public partial class Version3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StadiumName",
                table: "FootballClub",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StadiumName",
                table: "FootballClub");
        }
    }
}
