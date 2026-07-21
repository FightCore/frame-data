using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FightCore.Data.Migrations
{
    /// <inheritdoc />
    public partial class Added_AnimationCredits : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "animation_credit_id",
                table: "moves",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "credit_id",
                table: "alternative_animations",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "animation_credits",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    url = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_animation_credits", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "ix_moves_animation_credit_id",
                table: "moves",
                column: "animation_credit_id");

            migrationBuilder.CreateIndex(
                name: "ix_alternative_animations_credit_id",
                table: "alternative_animations",
                column: "credit_id");

            migrationBuilder.AddForeignKey(
                name: "fk_alternative_animations_animation_credits_credit_id",
                table: "alternative_animations",
                column: "credit_id",
                principalTable: "animation_credits",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_moves_animation_credits_animation_credit_id",
                table: "moves",
                column: "animation_credit_id",
                principalTable: "animation_credits",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_alternative_animations_animation_credits_credit_id",
                table: "alternative_animations");

            migrationBuilder.DropForeignKey(
                name: "fk_moves_animation_credits_animation_credit_id",
                table: "moves");

            migrationBuilder.DropTable(
                name: "animation_credits");

            migrationBuilder.DropIndex(
                name: "ix_moves_animation_credit_id",
                table: "moves");

            migrationBuilder.DropIndex(
                name: "ix_alternative_animations_credit_id",
                table: "alternative_animations");

            migrationBuilder.DropColumn(
                name: "animation_credit_id",
                table: "moves");

            migrationBuilder.DropColumn(
                name: "credit_id",
                table: "alternative_animations");
        }
    }
}
