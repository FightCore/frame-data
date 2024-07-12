using Microsoft.EntityFrameworkCore.Migrations;

namespace FightCore.FrameData.Migrations
{
    public partial class AppInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CharacterStatistics",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Weight = table.Column<int>(nullable: false),
                    Gravity = table.Column<double>(nullable: false),
                    WalkSpeed = table.Column<double>(nullable: false),
                    RunSpeed = table.Column<double>(nullable: false),
                    WaveDashLengthRank = table.Column<int>(nullable: false),
                    PLAIntangibilityFrames = table.Column<int>(nullable: false),
                    JumpSquat = table.Column<int>(nullable: false),
                    CanWallJump = table.Column<bool>(nullable: false),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterStatistics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true),
                    FightCoreId = table.Column<long>(nullable: false),
                    CharacterStatisticsId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_CharacterStatistics_CharacterStatisticsId",
                        column: x => x.CharacterStatisticsId,
                        principalTable: "CharacterStatistics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Move",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true),
                    LandLag = table.Column<string>(nullable: true),
                    LCanceledLandLag = table.Column<string>(nullable: true),
                    TotalFrames = table.Column<int>(nullable: false),
                    IASA = table.Column<int>(nullable: false),
                    AutoCancelBefore = table.Column<int>(nullable: false),
                    AutoCancelAfter = table.Column<int>(nullable: false),
                    CharacterId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Move", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Move_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Hitbox",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Damage = table.Column<long>(nullable: false),
                    Angle = table.Column<long>(nullable: false),
                    KnockbackGrowth = table.Column<long>(nullable: false),
                    SetKnockback = table.Column<long>(nullable: false),
                    BaseKnockback = table.Column<long>(nullable: false),
                    Effect = table.Column<string>(nullable: true),
                    HitlagAttacker = table.Column<int>(nullable: false),
                    HitlagDefender = table.Column<int>(nullable: false),
                    Shieldstun = table.Column<int>(nullable: false),
                    MoveId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hitbox", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hitbox_Move_MoveId",
                        column: x => x.MoveId,
                        principalTable: "Move",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_CharacterStatisticsId",
                table: "Characters",
                column: "CharacterStatisticsId");

            migrationBuilder.CreateIndex(
                name: "IX_Hitbox_MoveId",
                table: "Hitbox",
                column: "MoveId");

            migrationBuilder.CreateIndex(
                name: "IX_Move_CharacterId",
                table: "Move",
                column: "CharacterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hitbox");

            migrationBuilder.DropTable(
                name: "Move");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "CharacterStatistics");
        }
    }
}
