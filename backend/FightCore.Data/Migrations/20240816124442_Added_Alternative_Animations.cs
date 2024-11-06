using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FightCore.FrameData.Migrations
{
    /// <inheritdoc />
    public partial class Added_Alternative_Animations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PngUrl",
                table: "Moves",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WebmUrl",
                table: "Moves",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AlternativeAnimations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GifUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebmUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PngUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoveId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlternativeAnimations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlternativeAnimations_Moves_MoveId",
                        column: x => x.MoveId,
                        principalTable: "Moves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlternativeAnimations_MoveId",
                table: "AlternativeAnimations",
                column: "MoveId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlternativeAnimations");

            migrationBuilder.DropColumn(
                name: "PngUrl",
                table: "Moves");

            migrationBuilder.DropColumn(
                name: "WebmUrl",
                table: "Moves");
        }
    }
}
