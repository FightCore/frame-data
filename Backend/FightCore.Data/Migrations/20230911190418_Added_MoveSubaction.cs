using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FightCore.FrameData.Migrations
{
    /// <inheritdoc />
    public partial class Added_MoveSubaction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HitboxId",
                table: "HitboxCommands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MoveSubactions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MoveId = table.Column<long>(type: "bigint", nullable: false),
                    SubactionId = table.Column<long>(type: "bigint", nullable: false),
                    Frame = table.Column<int>(type: "int", nullable: false),
                    MatchType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoveSubactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MoveSubactions_Moves_MoveId",
                        column: x => x.MoveId,
                        principalTable: "Moves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_MoveSubactions_Subactions_SubactionId",
                        column: x => x.SubactionId,
                        principalTable: "Subactions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MoveSubactions_MoveId",
                table: "MoveSubactions",
                column: "MoveId");

            migrationBuilder.CreateIndex(
                name: "IX_MoveSubactions_SubactionId",
                table: "MoveSubactions",
                column: "SubactionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MoveSubactions");

            migrationBuilder.DropColumn(
                name: "HitboxId",
                table: "HitboxCommands");
        }
    }
}
