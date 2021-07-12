using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartAbp.Migrations
{
    public partial class Created_WeldSection_Entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WeldSection_Robot_RobotId",
                table: "WeldSection");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WeldSection",
                table: "WeldSection");

            migrationBuilder.RenameTable(
                name: "WeldSection",
                newName: "AppWeldSections");

            migrationBuilder.RenameIndex(
                name: "IX_WeldSection_RobotId",
                table: "AppWeldSections",
                newName: "IX_AppWeldSections_RobotId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppWeldSections",
                table: "AppWeldSections",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppWeldSections_Robot_RobotId",
                table: "AppWeldSections",
                column: "RobotId",
                principalTable: "Robot",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppWeldSections_Robot_RobotId",
                table: "AppWeldSections");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppWeldSections",
                table: "AppWeldSections");

            migrationBuilder.RenameTable(
                name: "AppWeldSections",
                newName: "WeldSection");

            migrationBuilder.RenameIndex(
                name: "IX_AppWeldSections_RobotId",
                table: "WeldSection",
                newName: "IX_WeldSection_RobotId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WeldSection",
                table: "WeldSection",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WeldSection_Robot_RobotId",
                table: "WeldSection",
                column: "RobotId",
                principalTable: "Robot",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
