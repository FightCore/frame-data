using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FightCore.FrameData.Migrations
{
    public partial class Added_YoshiArmorBreakPercentage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "YoshiArmorBreakPercentage",
                table: "Hitboxes",
                type: "int",
                nullable: true);

            migrationBuilder.Sql(@"EXEC('
			    CREATE FUNCTION CalculateYoshiArmorBreak(@hitboxId int)
                RETURNS DECIMAL
                WITH EXECUTE AS CALLER
                AS
                BEGIN
                    DECLARE @ArmorBreak DECIMAL
                    IF ((SELECT M.Type FROM [Moves] M INNER JOIN [Hitboxes] H ON H.MoveId = M.Id WHERE H.Id = @hitboxId) NOT IN (2, 4, 3, 1))
                        RETURN NULL
                
                    IF ((SELECT H.KnockbackGrowth FROM [Hitboxes] H WHERE H.Id = @hitboxId) = 0 OR (SELECT H.SetKnockback FROM [Hitboxes] H WHERE H.Id = @hitboxId) > 0)
                        RETURN NULL
                
                    SET @ArmorBreak = (SELECT ROUND((208 / 14) * (((100 / hitbox.KnockbackGrowth) * (120 - hitbox.BaseKnockback) - 18) / (hitbox.Damage + 2)) - hitbox.Damage, 2) FROM [Hitboxes] AS  Hitbox WHERE Id = @hitboxId);
                    IF (@ArmorBreak < 0)
                        RETURN 0;
                    RETURN @ArmorBreak
                END			
			    ')");

            migrationBuilder.Sql(@"EXEC('
				UPDATE Hitboxes
				SET YoshiArmorBreakPercentage = dbo.CalculateYoshiArmorBreak(Hitboxes.Id)
				')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YoshiArmorBreakPercentage",
                table: "Hitboxes");
        }
    }
}
