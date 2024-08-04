using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FightCore.FrameData.Migrations
{
    public partial class Rename_Plural_Tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_CharacterMiscInfo_CharacterInfoId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Hitbox_Move_MoveId",
                table: "Hitbox");

            migrationBuilder.DropForeignKey(
                name: "FK_Move_Characters_CharacterId",
                table: "Move");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Move",
                table: "Move");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hitbox",
                table: "Hitbox");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterMiscInfo",
                table: "CharacterMiscInfo");

            migrationBuilder.RenameTable(
                name: "Move",
                newName: "Moves");

            migrationBuilder.RenameTable(
                name: "Hitbox",
                newName: "Hitboxes");

            migrationBuilder.RenameTable(
                name: "CharacterMiscInfo",
                newName: "CharactersMiscInfos");

            migrationBuilder.RenameIndex(
                name: "IX_Move_CharacterId",
                table: "Moves",
                newName: "IX_Moves_CharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_Hitbox_MoveId",
                table: "Hitboxes",
                newName: "IX_Hitboxes_MoveId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Moves",
                table: "Moves",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hitboxes",
                table: "Hitboxes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharactersMiscInfos",
                table: "CharactersMiscInfos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_CharactersMiscInfos_CharacterInfoId",
                table: "Characters",
                column: "CharacterInfoId",
                principalTable: "CharactersMiscInfos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Hitboxes_Moves_MoveId",
                table: "Hitboxes",
                column: "MoveId",
                principalTable: "Moves",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Moves_Characters_CharacterId",
                table: "Moves",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_CharactersMiscInfos_CharacterInfoId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Hitboxes_Moves_MoveId",
                table: "Hitboxes");

            migrationBuilder.DropForeignKey(
                name: "FK_Moves_Characters_CharacterId",
                table: "Moves");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Moves",
                table: "Moves");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hitboxes",
                table: "Hitboxes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharactersMiscInfos",
                table: "CharactersMiscInfos");

            migrationBuilder.RenameTable(
                name: "Moves",
                newName: "Move");

            migrationBuilder.RenameTable(
                name: "Hitboxes",
                newName: "Hitbox");

            migrationBuilder.RenameTable(
                name: "CharactersMiscInfos",
                newName: "CharacterMiscInfo");

            migrationBuilder.RenameIndex(
                name: "IX_Moves_CharacterId",
                table: "Move",
                newName: "IX_Move_CharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_Hitboxes_MoveId",
                table: "Hitbox",
                newName: "IX_Hitbox_MoveId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Move",
                table: "Move",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hitbox",
                table: "Hitbox",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterMiscInfo",
                table: "CharacterMiscInfo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_CharacterMiscInfo_CharacterInfoId",
                table: "Characters",
                column: "CharacterInfoId",
                principalTable: "CharacterMiscInfo",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Hitbox_Move_MoveId",
                table: "Hitbox",
                column: "MoveId",
                principalTable: "Move",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Move_Characters_CharacterId",
                table: "Move",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
