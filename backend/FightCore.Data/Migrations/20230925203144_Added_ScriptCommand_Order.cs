using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FightCore.FrameData.Migrations
{
    /// <inheritdoc />
    public partial class Added_ScriptCommand_Order : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "ScriptCommands",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Order",
                table: "ScriptCommands");
        }
    }
}
