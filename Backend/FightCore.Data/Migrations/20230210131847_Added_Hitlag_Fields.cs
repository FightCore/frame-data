using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FightCore.FrameData.Migrations
{
    public partial class Added_Hitlag_Fields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hitbox_Move_MoveId",
                table: "Hitbox");

            migrationBuilder.DropColumn(
                name: "GIFSource",
                table: "Move");

            migrationBuilder.DropColumn(
                name: "InvulnerableEnd",
                table: "Move");

            migrationBuilder.DropColumn(
                name: "InvulnerableStart",
                table: "Move");

            migrationBuilder.AlterColumn<long>(
                name: "MoveId",
                table: "Hitbox",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HitlagAttackerCrouched",
                table: "Hitbox",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HitlagDefenderCrouched",
                table: "Hitbox",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Hitbox_Move_MoveId",
                table: "Hitbox",
                column: "MoveId",
                principalTable: "Move",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.Sql(@"
		EXEC('CREATE FUNCTION CalculateHitlag(@hitboxId int, @isDefender bit, @isCrouched bit)
			RETURNS INT
			WITH EXECUTE AS CALLER
			AS
			BEGIN
				DECLARE @Hitlag DECIMAL;
				IF ((SELECT H.Damage FROM [Hitbox] H WHERE H.Id = @hitboxId) = 0)
					RETURN 0;

				SET @Hitlag = (SELECT ROUND(CAST(H.Damage AS DECIMAL) / 3.0 + 3.0, 0)
					FROM [Hitbox] H
					WHERE H.Id = @hitboxId);

                IF ((SELECT H.Effect FROM [Hitbox] H WHERE H.Id = @hitboxId) = ''Electric'' AND @isDefender = 1)
                    SET @Hitlag = ROUND(@Hitlag * 1.5, 0)

                IF (@isCrouched = 1)
                    SET @Hitlag = ROUND(@Hitlag * 0.666667, 0)

                IF (@Hitlag >= 20)
                    RETURN 20;

                RETURN @Hitlag;
			END')");

            migrationBuilder.Sql(@"EXEC('
			UPDATE Hitbox
			SET HitlagAttacker = dbo.CalculateHitlag(Hitbox.Id, 0, 0),
				HitlagAttackerCrouched = dbo.CalculateHitlag(Hitbox.Id, 0, 1),
				HitlagDefender = dbo.CalculateHitlag(Hitbox.Id, 1, 0),
				HitlagDefenderCrouched = dbo.CalculateHitlag(Hitbox.Id, 1, 1)
			')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hitbox_Move_MoveId",
                table: "Hitbox");

            migrationBuilder.DropColumn(
                name: "HitlagAttackerCrouched",
                table: "Hitbox");

            migrationBuilder.DropColumn(
                name: "HitlagDefenderCrouched",
                table: "Hitbox");

            migrationBuilder.AddColumn<string>(
                name: "GIFSource",
                table: "Move",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InvulnerableEnd",
                table: "Move",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InvulnerableStart",
                table: "Move",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "MoveId",
                table: "Hitbox",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_Hitbox_Move_MoveId",
                table: "Hitbox",
                column: "MoveId",
                principalTable: "Move",
                principalColumn: "Id");
        }
    }
}
