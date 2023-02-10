using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FightCore.FrameData.Migrations
{
    public partial class Make_Iasa_null : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
	        migrationBuilder.Sql("EXEC('UPDATE Moves SET IASA = NULL WHERE IASA = 0')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
	        migrationBuilder.Sql("EXEC('UPDATE Moves SET IASA = 0 WHERE IASA IS NULL')");

		}
	}
}
