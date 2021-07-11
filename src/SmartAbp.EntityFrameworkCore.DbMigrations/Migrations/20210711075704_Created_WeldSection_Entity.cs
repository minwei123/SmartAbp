using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartAbp.Migrations
{
    public partial class Created_WeldSection_Entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppWeldSections",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    voltage = table.Column<float>(type: "real", nullable: false),
                    current = table.Column<float>(type: "real", nullable: false),
                    speed = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppWeldSections", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppWeldSections");
        }
    }
}
