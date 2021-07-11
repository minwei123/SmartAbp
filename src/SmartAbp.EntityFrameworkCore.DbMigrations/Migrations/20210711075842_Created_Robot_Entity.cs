using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartAbp.Migrations
{
    public partial class Created_Robot_Entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "RobotId",
                table: "AppWeldSections",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AppRobots",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRobots", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppWeldSections_RobotId",
                table: "AppWeldSections",
                column: "RobotId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppWeldSections_AppRobots_RobotId",
                table: "AppWeldSections",
                column: "RobotId",
                principalTable: "AppRobots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppWeldSections_AppRobots_RobotId",
                table: "AppWeldSections");

            migrationBuilder.DropTable(
                name: "AppRobots");

            migrationBuilder.DropIndex(
                name: "IX_AppWeldSections_RobotId",
                table: "AppWeldSections");

            migrationBuilder.DropColumn(
                name: "RobotId",
                table: "AppWeldSections");
        }
    }
}
