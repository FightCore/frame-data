using Microsoft.EntityFrameworkCore.Migrations;

namespace FightCore.FrameData.Migrations
{
    public partial class AddedDodgesData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "End",
                table: "Move",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Move",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Percent",
                table: "Move",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Start",
                table: "Move",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "End",
                table: "Move");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Move");

            migrationBuilder.DropColumn(
                name: "Percent",
                table: "Move");

            migrationBuilder.DropColumn(
                name: "Start",
                table: "Move");
        }
    }
}
