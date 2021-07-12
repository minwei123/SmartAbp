using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartAbp.Migrations
{
    public partial class Created_Robot_Entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppWeldSections_Robot_RobotId",
                table: "AppWeldSections");

            migrationBuilder.DropForeignKey(
                name: "FK_Robot_AppStations_StationId",
                table: "Robot");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Robot",
                table: "Robot");

            migrationBuilder.RenameTable(
                name: "Robot",
                newName: "AppRobots");

            migrationBuilder.RenameIndex(
                name: "IX_Robot_StationId",
                table: "AppRobots",
                newName: "IX_AppRobots_StationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppRobots",
                table: "AppRobots",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppRobots_AppStations_StationId",
                table: "AppRobots",
                column: "StationId",
                principalTable: "AppStations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_AppRobots_AppStations_StationId",
                table: "AppRobots");

            migrationBuilder.DropForeignKey(
                name: "FK_AppWeldSections_AppRobots_RobotId",
                table: "AppWeldSections");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppRobots",
                table: "AppRobots");

            migrationBuilder.RenameTable(
                name: "AppRobots",
                newName: "Robot");

            migrationBuilder.RenameIndex(
                name: "IX_AppRobots_StationId",
                table: "Robot",
                newName: "IX_Robot_StationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Robot",
                table: "Robot",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppWeldSections_Robot_RobotId",
                table: "AppWeldSections",
                column: "RobotId",
                principalTable: "Robot",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Robot_AppStations_StationId",
                table: "Robot",
                column: "StationId",
                principalTable: "AppStations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
