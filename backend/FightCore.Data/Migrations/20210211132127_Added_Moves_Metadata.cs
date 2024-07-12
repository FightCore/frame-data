using Microsoft.EntityFrameworkCore.Migrations;

namespace FightCore.FrameData.Migrations
{
    public partial class Added_Moves_Metadata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GIFSource",
                table: "Move",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InvulnerableEnd",
                table: "Move",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InvulnerableStart",
                table: "Move",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GIFSource",
                table: "Move");

            migrationBuilder.DropColumn(
                name: "InvulnerableEnd",
                table: "Move");

            migrationBuilder.DropColumn(
                name: "InvulnerableStart",
                table: "Move");
        }
    }
}
