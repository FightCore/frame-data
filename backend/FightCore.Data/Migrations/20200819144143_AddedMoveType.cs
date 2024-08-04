using Microsoft.EntityFrameworkCore.Migrations;

namespace FightCore.FrameData.Migrations
{
    public partial class AddedMoveType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Move",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Move");
        }
    }
}
