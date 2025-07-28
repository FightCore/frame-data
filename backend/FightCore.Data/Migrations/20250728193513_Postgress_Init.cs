using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FightCore.Data.Migrations
{
    /// <inheritdoc />
    public partial class Postgress_Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CharactersMiscInfos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Discord = table.Column<string>(type: "text", nullable: true),
                    MeleeFrameData = table.Column<string>(type: "text", nullable: true),
                    SsbWiki = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharactersMiscInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CharacterStatistics",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Weight = table.Column<int>(type: "integer", nullable: false),
                    Gravity = table.Column<double>(type: "double precision", nullable: false),
                    WalkSpeed = table.Column<double>(type: "double precision", nullable: false),
                    RunSpeed = table.Column<double>(type: "double precision", nullable: false),
                    WaveDashLengthRank = table.Column<int>(type: "integer", nullable: false),
                    PLAIntangibilityFrames = table.Column<int>(type: "integer", nullable: false),
                    JumpSquat = table.Column<int>(type: "integer", nullable: false),
                    CanWallJump = table.Column<bool>(type: "boolean", nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: true),
                    InitialDash = table.Column<double>(type: "double precision", nullable: false),
                    DashFrames = table.Column<int>(type: "integer", nullable: false),
                    WaveDashLength = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterStatistics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sources",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Url = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sources", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    NormalizedName = table.Column<string>(type: "text", nullable: true),
                    FightCoreId = table.Column<long>(type: "bigint", nullable: false),
                    CharacterStatisticsId = table.Column<long>(type: "bigint", nullable: true),
                    CharacterInfoId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_CharacterStatistics_CharacterStatisticsId",
                        column: x => x.CharacterStatisticsId,
                        principalTable: "CharacterStatistics",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Characters_CharactersMiscInfos_CharacterInfoId",
                        column: x => x.CharacterInfoId,
                        principalTable: "CharactersMiscInfos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Moves",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    NormalizedName = table.Column<string>(type: "text", nullable: true),
                    LandLag = table.Column<int>(type: "integer", nullable: true),
                    LCanceledLandLag = table.Column<int>(type: "integer", nullable: true),
                    LandingFallSpecialLag = table.Column<int>(type: "integer", nullable: true),
                    TotalFrames = table.Column<int>(type: "integer", nullable: false),
                    IASA = table.Column<int>(type: "integer", nullable: true),
                    AutoCancelBefore = table.Column<int>(type: "integer", nullable: true),
                    AutoCancelAfter = table.Column<int>(type: "integer", nullable: true),
                    Start = table.Column<int>(type: "integer", nullable: true),
                    End = table.Column<int>(type: "integer", nullable: true),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: true),
                    Percent = table.Column<int>(type: "integer", nullable: true),
                    CharacterId = table.Column<long>(type: "bigint", nullable: false),
                    Source = table.Column<string>(type: "text", nullable: true),
                    GifUrl = table.Column<string>(type: "text", nullable: true),
                    WebmUrl = table.Column<string>(type: "text", nullable: true),
                    PngUrl = table.Column<string>(type: "text", nullable: true),
                    IsInterpolated = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Moves_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subactions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Index = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CharacterId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subactions_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AlternativeAnimations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "text", nullable: true),
                    GifUrl = table.Column<string>(type: "text", nullable: true),
                    WebmUrl = table.Column<string>(type: "text", nullable: true),
                    PngUrl = table.Column<string>(type: "text", nullable: true),
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

            migrationBuilder.CreateTable(
                name: "Hits",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Start = table.Column<int>(type: "integer", nullable: false),
                    End = table.Column<int>(type: "integer", nullable: false),
                    MoveId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hits_Moves_MoveId",
                        column: x => x.MoveId,
                        principalTable: "Moves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MoveSource",
                columns: table => new
                {
                    MovesId = table.Column<long>(type: "bigint", nullable: false),
                    SourcesId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoveSource", x => new { x.MovesId, x.SourcesId });
                    table.ForeignKey(
                        name: "FK_MoveSource_Moves_MovesId",
                        column: x => x.MovesId,
                        principalTable: "Moves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MoveSource_Sources_SourcesId",
                        column: x => x.SourcesId,
                        principalTable: "Sources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MoveSubactions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MoveId = table.Column<long>(type: "bigint", nullable: false),
                    SubactionId = table.Column<long>(type: "bigint", nullable: false),
                    Frame = table.Column<int>(type: "integer", nullable: false),
                    MatchType = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoveSubactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MoveSubactions_Moves_MoveId",
                        column: x => x.MoveId,
                        principalTable: "Moves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MoveSubactions_Subactions_SubactionId",
                        column: x => x.SubactionId,
                        principalTable: "Subactions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScriptCommands",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    DisplayName = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<long>(type: "bigint", nullable: false),
                    Length = table.Column<long>(type: "bigint", nullable: false),
                    HexString = table.Column<string>(type: "text", nullable: true),
                    SubactionId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScriptCommands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScriptCommands_Subactions_SubactionId",
                        column: x => x.SubactionId,
                        principalTable: "Subactions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SubactionHeader",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StringOffset = table.Column<long>(type: "bigint", nullable: false),
                    ScriptOffset = table.Column<long>(type: "bigint", nullable: false),
                    Unknown1Offset = table.Column<long>(type: "bigint", nullable: false),
                    Unknown2Offset = table.Column<long>(type: "bigint", nullable: false),
                    Unknown3Flags = table.Column<long>(type: "bigint", nullable: false),
                    Unknown4Offset = table.Column<long>(type: "bigint", nullable: false),
                    SubactionId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubactionHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubactionHeader_Subactions_SubactionId",
                        column: x => x.SubactionId,
                        principalTable: "Subactions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hitboxes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Damage = table.Column<long>(type: "bigint", nullable: false),
                    Angle = table.Column<long>(type: "bigint", nullable: false),
                    KnockbackGrowth = table.Column<long>(type: "bigint", nullable: false),
                    SetKnockback = table.Column<long>(type: "bigint", nullable: false),
                    BaseKnockback = table.Column<long>(type: "bigint", nullable: false),
                    Effect = table.Column<string>(type: "text", nullable: true),
                    HitlagAttacker = table.Column<int>(type: "integer", nullable: false),
                    HitlagDefender = table.Column<int>(type: "integer", nullable: false),
                    HitlagAttackerCrouched = table.Column<int>(type: "integer", nullable: false),
                    HitlagDefenderCrouched = table.Column<int>(type: "integer", nullable: false),
                    Shieldstun = table.Column<int>(type: "integer", nullable: false),
                    YoshiArmorBreakPercentage = table.Column<int>(type: "integer", nullable: true),
                    IsWeightIndependent = table.Column<bool>(type: "boolean", nullable: false),
                    HitId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hitboxes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hitboxes_Hits_HitId",
                        column: x => x.HitId,
                        principalTable: "Hits",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AutoCancelCommands",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    AutoCancelEnabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoCancelCommands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AutoCancelCommands_ScriptCommands_Id",
                        column: x => x.Id,
                        principalTable: "ScriptCommands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BodyStateCommands",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    BodyType = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyStateCommands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BodyStateCommands_ScriptCommands_Id",
                        column: x => x.Id,
                        principalTable: "ScriptCommands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HitboxCommands",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    HitboxId = table.Column<int>(type: "integer", nullable: false),
                    UnknownR = table.Column<int>(type: "integer", nullable: false),
                    BoneId = table.Column<int>(type: "integer", nullable: false),
                    Unknown0 = table.Column<int>(type: "integer", nullable: false),
                    UnknownQ = table.Column<int>(type: "integer", nullable: false),
                    UnknownV = table.Column<int>(type: "integer", nullable: false),
                    Size = table.Column<int>(type: "integer", nullable: false),
                    ZOffset = table.Column<int>(type: "integer", nullable: false),
                    YOffset = table.Column<int>(type: "integer", nullable: false),
                    XOffset = table.Column<int>(type: "integer", nullable: false),
                    HurtboxInteraction = table.Column<int>(type: "integer", nullable: false),
                    BaseKnockback = table.Column<int>(type: "integer", nullable: false),
                    ShieldDamage = table.Column<int>(type: "integer", nullable: false),
                    SFX = table.Column<int>(type: "integer", nullable: false),
                    HitsGround = table.Column<bool>(type: "boolean", nullable: false),
                    HitsAir = table.Column<bool>(type: "boolean", nullable: false),
                    KnockbackGrowth = table.Column<int>(type: "integer", nullable: false),
                    Damage = table.Column<int>(type: "integer", nullable: false),
                    WeightDependantKnockback = table.Column<int>(type: "integer", nullable: false),
                    Element = table.Column<int>(type: "integer", nullable: false),
                    Angle = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HitboxCommands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HitboxCommands_ScriptCommands_Id",
                        column: x => x.Id,
                        principalTable: "ScriptCommands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PartialBodystateCommands",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    Bone = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartialBodystateCommands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PartialBodystateCommands_ScriptCommands_Id",
                        column: x => x.Id,
                        principalTable: "ScriptCommands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PointerCommands",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    Pointer = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PointerCommands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PointerCommands_ScriptCommands_Id",
                        column: x => x.Id,
                        principalTable: "ScriptCommands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StartLoopCommands",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    Iterations = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StartLoopCommands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StartLoopCommands_ScriptCommands_Id",
                        column: x => x.Id,
                        principalTable: "ScriptCommands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThrowCommands",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    ThrowType = table.Column<int>(type: "integer", nullable: false),
                    Damage = table.Column<int>(type: "integer", nullable: false),
                    KnockbackGrowth = table.Column<int>(type: "integer", nullable: false),
                    WeightDependantKnockback = table.Column<int>(type: "integer", nullable: false),
                    ThrowElement = table.Column<int>(type: "integer", nullable: false),
                    Angle = table.Column<int>(type: "integer", nullable: false),
                    BaseKnockback = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThrowCommands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ThrowCommands_ScriptCommands_Id",
                        column: x => x.Id,
                        principalTable: "ScriptCommands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TimerCommands",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    Frames = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimerCommands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TimerCommands_ScriptCommands_Id",
                        column: x => x.Id,
                        principalTable: "ScriptCommands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UnsolvedCommands",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnsolvedCommands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnsolvedCommands_ScriptCommands_Id",
                        column: x => x.Id,
                        principalTable: "ScriptCommands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VisibilityCommands",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    Visibility = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisibilityCommands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VisibilityCommands_ScriptCommands_Id",
                        column: x => x.Id,
                        principalTable: "ScriptCommands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlternativeAnimations_MoveId",
                table: "AlternativeAnimations",
                column: "MoveId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_CharacterInfoId",
                table: "Characters",
                column: "CharacterInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_CharacterStatisticsId",
                table: "Characters",
                column: "CharacterStatisticsId");

            migrationBuilder.CreateIndex(
                name: "IX_Hitboxes_HitId",
                table: "Hitboxes",
                column: "HitId");

            migrationBuilder.CreateIndex(
                name: "IX_Hits_MoveId",
                table: "Hits",
                column: "MoveId");

            migrationBuilder.CreateIndex(
                name: "IX_Moves_CharacterId",
                table: "Moves",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_MoveSource_SourcesId",
                table: "MoveSource",
                column: "SourcesId");

            migrationBuilder.CreateIndex(
                name: "IX_MoveSubactions_MoveId",
                table: "MoveSubactions",
                column: "MoveId");

            migrationBuilder.CreateIndex(
                name: "IX_MoveSubactions_SubactionId",
                table: "MoveSubactions",
                column: "SubactionId");

            migrationBuilder.CreateIndex(
                name: "IX_ScriptCommands_SubactionId",
                table: "ScriptCommands",
                column: "SubactionId");

            migrationBuilder.CreateIndex(
                name: "IX_SubactionHeader_SubactionId",
                table: "SubactionHeader",
                column: "SubactionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subactions_CharacterId",
                table: "Subactions",
                column: "CharacterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlternativeAnimations");

            migrationBuilder.DropTable(
                name: "AutoCancelCommands");

            migrationBuilder.DropTable(
                name: "BodyStateCommands");

            migrationBuilder.DropTable(
                name: "HitboxCommands");

            migrationBuilder.DropTable(
                name: "Hitboxes");

            migrationBuilder.DropTable(
                name: "MoveSource");

            migrationBuilder.DropTable(
                name: "MoveSubactions");

            migrationBuilder.DropTable(
                name: "PartialBodystateCommands");

            migrationBuilder.DropTable(
                name: "PointerCommands");

            migrationBuilder.DropTable(
                name: "StartLoopCommands");

            migrationBuilder.DropTable(
                name: "SubactionHeader");

            migrationBuilder.DropTable(
                name: "ThrowCommands");

            migrationBuilder.DropTable(
                name: "TimerCommands");

            migrationBuilder.DropTable(
                name: "UnsolvedCommands");

            migrationBuilder.DropTable(
                name: "VisibilityCommands");

            migrationBuilder.DropTable(
                name: "Hits");

            migrationBuilder.DropTable(
                name: "Sources");

            migrationBuilder.DropTable(
                name: "ScriptCommands");

            migrationBuilder.DropTable(
                name: "Moves");

            migrationBuilder.DropTable(
                name: "Subactions");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "CharacterStatistics");

            migrationBuilder.DropTable(
                name: "CharactersMiscInfos");
        }
    }
}
