using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartAbp.Migrations
{
    public partial class Added_AppUser_Properties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Avatar",
                table: "AbpUsers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Introduction",
                table: "AbpUsers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "AbpUsers");

            migrationBuilder.DropColumn(
                name: "Introduction",
                table: "AbpUsers");
        }
    }
}
