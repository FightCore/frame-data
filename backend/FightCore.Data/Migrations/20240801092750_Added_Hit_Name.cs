using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FightCore.FrameData.Migrations
{
    /// <inheritdoc />
    public partial class Added_Hit_Name : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hits_Moves_MoveId",
                table: "Hits");

            migrationBuilder.AlterColumn<long>(
                name: "MoveId",
                table: "Hits",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Hits",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Hits_Moves_MoveId",
                table: "Hits",
                column: "MoveId",
                principalTable: "Moves",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hits_Moves_MoveId",
                table: "Hits");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Hits");

            migrationBuilder.AlterColumn<long>(
                name: "MoveId",
                table: "Hits",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_Hits_Moves_MoveId",
                table: "Hits",
                column: "MoveId",
                principalTable: "Moves",
                principalColumn: "Id");
        }
    }
}
