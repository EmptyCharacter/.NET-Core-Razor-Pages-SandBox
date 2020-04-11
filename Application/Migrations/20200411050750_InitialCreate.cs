using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Application.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EntryInfo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployerName = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Decision = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntryInfo", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntryInfo");
        }
    }
}
