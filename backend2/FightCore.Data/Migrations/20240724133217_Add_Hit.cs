using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FightCore.FrameData.Migrations
{
    /// <inheritdoc />
    public partial class Add_Hit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hitboxes_Moves_MoveId",
                table: "Hitboxes");

            migrationBuilder.DropIndex(
                name: "IX_Hitboxes_MoveId",
                table: "Hitboxes");

            migrationBuilder.DropColumn(
                name: "MoveId",
                table: "Hitboxes");

            migrationBuilder.AddColumn<long>(
                name: "HitId",
                table: "Hitboxes",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Hits",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Start = table.Column<int>(type: "int", nullable: false),
                    End = table.Column<int>(type: "int", nullable: false),
                    MoveId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hits_Moves_MoveId",
                        column: x => x.MoveId,
                        principalTable: "Moves",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hitboxes_HitId",
                table: "Hitboxes",
                column: "HitId");

            migrationBuilder.CreateIndex(
                name: "IX_Hits_MoveId",
                table: "Hits",
                column: "MoveId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hitboxes_Hits_HitId",
                table: "Hitboxes",
                column: "HitId",
                principalTable: "Hits",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hitboxes_Hits_HitId",
                table: "Hitboxes");

            migrationBuilder.DropTable(
                name: "Hits");

            migrationBuilder.DropIndex(
                name: "IX_Hitboxes_HitId",
                table: "Hitboxes");

            migrationBuilder.DropColumn(
                name: "HitId",
                table: "Hitboxes");

            migrationBuilder.AddColumn<long>(
                name: "MoveId",
                table: "Hitboxes",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Hitboxes_MoveId",
                table: "Hitboxes",
                column: "MoveId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hitboxes_Moves_MoveId",
                table: "Hitboxes",
                column: "MoveId",
                principalTable: "Moves",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
