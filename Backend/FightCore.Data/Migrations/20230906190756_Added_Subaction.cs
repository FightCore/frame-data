using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FightCore.FrameData.Migrations
{
    /// <inheritdoc />
    public partial class Added_Subaction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Subactions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Index = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subactions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScriptCommands",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<long>(type: "bigint", nullable: false),
                    Length = table.Column<long>(type: "bigint", nullable: false),
                    HexString = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                name: "AutoCancelCommands",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    AutoCancelEnabled = table.Column<bool>(type: "bit", nullable: false)
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
                    BodyType = table.Column<int>(type: "int", nullable: false)
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
                    UnknownR = table.Column<int>(type: "int", nullable: false),
                    BoneId = table.Column<int>(type: "int", nullable: false),
                    Unknown0 = table.Column<int>(type: "int", nullable: false),
                    UnknownQ = table.Column<int>(type: "int", nullable: false),
                    UnknownV = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    ZOffset = table.Column<int>(type: "int", nullable: false),
                    YOffset = table.Column<int>(type: "int", nullable: false),
                    XOffset = table.Column<int>(type: "int", nullable: false),
                    HurtboxInteraction = table.Column<int>(type: "int", nullable: false),
                    BaseKnockback = table.Column<int>(type: "int", nullable: false),
                    ShieldDamage = table.Column<int>(type: "int", nullable: false),
                    SFX = table.Column<int>(type: "int", nullable: false),
                    HitsGround = table.Column<bool>(type: "bit", nullable: false),
                    HitsAir = table.Column<bool>(type: "bit", nullable: false),
                    KnockbackGrowth = table.Column<int>(type: "int", nullable: false),
                    Damage = table.Column<int>(type: "int", nullable: false),
                    WeightDependantKnockback = table.Column<int>(type: "int", nullable: false),
                    Element = table.Column<int>(type: "int", nullable: false),
                    Angle = table.Column<int>(type: "int", nullable: false)
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
                    Bone = table.Column<int>(type: "int", nullable: false)
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
                    Iterations = table.Column<int>(type: "int", nullable: false)
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
                    ThrowType = table.Column<int>(type: "int", nullable: false),
                    Damage = table.Column<int>(type: "int", nullable: false),
                    KnockbackGrowth = table.Column<int>(type: "int", nullable: false),
                    WeightDependantKnockback = table.Column<int>(type: "int", nullable: false),
                    ThrowElement = table.Column<int>(type: "int", nullable: false),
                    Angle = table.Column<int>(type: "int", nullable: false),
                    BaseKnockback = table.Column<int>(type: "int", nullable: false)
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
                    Frames = table.Column<int>(type: "int", nullable: false)
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
                    Visibility = table.Column<int>(type: "int", nullable: false)
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
                name: "IX_ScriptCommands_SubactionId",
                table: "ScriptCommands",
                column: "SubactionId");

            migrationBuilder.CreateIndex(
                name: "IX_SubactionHeader_SubactionId",
                table: "SubactionHeader",
                column: "SubactionId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutoCancelCommands");

            migrationBuilder.DropTable(
                name: "BodyStateCommands");

            migrationBuilder.DropTable(
                name: "HitboxCommands");

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
                name: "ScriptCommands");

            migrationBuilder.DropTable(
                name: "Subactions");
        }
    }
}
