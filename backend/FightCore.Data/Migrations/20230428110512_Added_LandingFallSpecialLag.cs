using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FightCore.FrameData.Migrations
{
    /// <inheritdoc />
    public partial class Added_LandingFallSpecialLag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LandingFallSpecialLag",
                table: "Moves",
                type: "int",
                nullable: true);

			/**
             * The following SQL Script was used to update the values in the FightCore Database
             * CREATE TABLE ##SpecialFall
                (
                    Character NVARCHAR(50) NOT NULL,
                    Move NVARCHAR(50) NOT NULL,
                    Frames int NOT NULL
                )
                INSERT INTO ##SpecialFall VALUES
                ('bowser','aupb',10),
                ('captainfalcon','asideb',20),
                ('captainfalcon','aupb',30),
                ('captainfalcon','upb',30),
                ('donkeykong','aupb',7),
                ('drmario','aupb',30),
                ('drmario','upb',30),
                ('falco','asideb',3),
                ('falco','aupb',3),
                ('fox','asideb',3),
                ('ganondorf','asideb',40),
                ('ganondorf','upb',30),
                ('iceclimbers','asideb',4),
                ('iceclimbers','upb',25),
                ('link','aupb',24),
                ('luigi','upb',40),
                ('mario','upb',30),
                ('marth','upb',34),
                ('mrgame&watch','upb',6),
                ('ness','aneutralb',6),
                ('ness','upb',20),
                ('peach','upb',4),
                ('pichu','upb',1),
                ('pikachu','upb',4),
                ('roy','upb',30),
                ('samus','aupb',24),
                ('samus','upb',24),
                ('sheik','upb',4),
                ('zelda','asideb',4),
                ('zelda','sideb',4),
                ('zelda','upb',4)
                
                UPDATE Moves
                SET LandingFallSpecialLag = Frames
                FROM dbo.Moves
                INNER JOIN dbo.Characters
                ON Moves.CharacterId = Characters.Id
                INNER JOIN ##SpecialFall
                ON ##SpecialFall.[Character] = Characters.NormalizedName
                AND ##SpecialFall.[Move] = Moves.NormalizedName;
                
                DROP Table ##SpecialFall
        */
	    }

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LandingFallSpecialLag",
                table: "Moves");
        }
    }
}
