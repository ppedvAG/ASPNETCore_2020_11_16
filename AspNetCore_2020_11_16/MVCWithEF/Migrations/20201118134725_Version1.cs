using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCWithEF.Migrations
{
    public partial class Version1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artikel",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Titel = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    PublishedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artikel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artikel");
        }
    }
}
