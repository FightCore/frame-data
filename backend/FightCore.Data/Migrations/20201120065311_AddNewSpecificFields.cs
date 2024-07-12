using Microsoft.EntityFrameworkCore.Migrations;

namespace FightCore.FrameData.Migrations
{
    public partial class AddNewSpecificFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Move_Characters_CharacterId",
                table: "Move");

            migrationBuilder.AlterColumn<long>(
                name: "CharacterId",
                table: "Move",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Source",
                table: "Move",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DashFrames",
                table: "CharacterStatistics",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "InitialDash",
                table: "CharacterStatistics",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "WaveDashLength",
                table: "CharacterStatistics",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddForeignKey(
                name: "FK_Move_Characters_CharacterId",
                table: "Move",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Move_Characters_CharacterId",
                table: "Move");

            migrationBuilder.DropColumn(
                name: "Source",
                table: "Move");

            migrationBuilder.DropColumn(
                name: "DashFrames",
                table: "CharacterStatistics");

            migrationBuilder.DropColumn(
                name: "InitialDash",
                table: "CharacterStatistics");

            migrationBuilder.DropColumn(
                name: "WaveDashLength",
                table: "CharacterStatistics");

            migrationBuilder.AlterColumn<long>(
                name: "CharacterId",
                table: "Move",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AddForeignKey(
                name: "FK_Move_Characters_CharacterId",
                table: "Move",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
