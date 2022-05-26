using Microsoft.EntityFrameworkCore.Migrations;

namespace FightCore.FrameData.Migrations
{
    public partial class AddKeyToCharacterInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CharacterInfoId",
                table: "Characters",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CharacterMiscInfo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Discord = table.Column<string>(nullable: true),
                    MeleeFrameData = table.Column<string>(nullable: true),
                    SsbWiki = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterMiscInfo", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_CharacterInfoId",
                table: "Characters",
                column: "CharacterInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_CharacterMiscInfo_CharacterInfoId",
                table: "Characters",
                column: "CharacterInfoId",
                principalTable: "CharacterMiscInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_CharacterMiscInfo_CharacterInfoId",
                table: "Characters");

            migrationBuilder.DropTable(
                name: "CharacterMiscInfo");

            migrationBuilder.DropIndex(
                name: "IX_Characters_CharacterInfoId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "CharacterInfoId",
                table: "Characters");
        }
    }
}
