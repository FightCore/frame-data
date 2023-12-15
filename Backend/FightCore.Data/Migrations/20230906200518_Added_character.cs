using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FightCore.FrameData.Migrations
{
    /// <inheritdoc />
    public partial class Added_character : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CharacterId",
                table: "Subactions",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Subactions_CharacterId",
                table: "Subactions",
                column: "CharacterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subactions_Characters_CharacterId",
                table: "Subactions",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subactions_Characters_CharacterId",
                table: "Subactions");

            migrationBuilder.DropIndex(
                name: "IX_Subactions_CharacterId",
                table: "Subactions");

            migrationBuilder.DropColumn(
                name: "CharacterId",
                table: "Subactions");
        }
    }
}
