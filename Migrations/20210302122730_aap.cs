using Microsoft.EntityFrameworkCore.Migrations;

namespace BetlApp.Migrations
{
    public partial class aap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Obj_defs",
                table: "Obj_defs");

            migrationBuilder.RenameTable(
                name: "Obj_defs",
                newName: "Obj_def");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Obj_def",
                table: "Obj_def",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Obj_def",
                table: "Obj_def");

            migrationBuilder.RenameTable(
                name: "Obj_def",
                newName: "Obj_defs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Obj_defs",
                table: "Obj_defs",
                column: "Id");
        }
    }
}
