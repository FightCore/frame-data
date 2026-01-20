using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FightCore.Data.Migrations
{
    /// <inheritdoc />
    public partial class PostgresNamingConvention : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlternativeAnimations_Moves_MoveId",
                table: "AlternativeAnimations");

            migrationBuilder.DropForeignKey(
                name: "FK_AutoCancelCommands_ScriptCommands_Id",
                table: "AutoCancelCommands");

            migrationBuilder.DropForeignKey(
                name: "FK_BodyStateCommands_ScriptCommands_Id",
                table: "BodyStateCommands");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_CharacterStatistics_CharacterStatisticsId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_CharactersMiscInfos_CharacterInfoId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_HitboxCommands_ScriptCommands_Id",
                table: "HitboxCommands");

            migrationBuilder.DropForeignKey(
                name: "FK_Hitboxes_Hits_HitId",
                table: "Hitboxes");

            migrationBuilder.DropForeignKey(
                name: "FK_Hits_Moves_MoveId",
                table: "Hits");

            migrationBuilder.DropForeignKey(
                name: "FK_Moves_Characters_CharacterId",
                table: "Moves");

            migrationBuilder.DropForeignKey(
                name: "FK_MoveSource_Moves_MovesId",
                table: "MoveSource");

            migrationBuilder.DropForeignKey(
                name: "FK_MoveSource_Sources_SourcesId",
                table: "MoveSource");

            migrationBuilder.DropForeignKey(
                name: "FK_MoveSubactions_Moves_MoveId",
                table: "MoveSubactions");

            migrationBuilder.DropForeignKey(
                name: "FK_MoveSubactions_Subactions_SubactionId",
                table: "MoveSubactions");

            migrationBuilder.DropForeignKey(
                name: "FK_PartialBodystateCommands_ScriptCommands_Id",
                table: "PartialBodystateCommands");

            migrationBuilder.DropForeignKey(
                name: "FK_PointerCommands_ScriptCommands_Id",
                table: "PointerCommands");

            migrationBuilder.DropForeignKey(
                name: "FK_ScriptCommands_Subactions_SubactionId",
                table: "ScriptCommands");

            migrationBuilder.DropForeignKey(
                name: "FK_StartLoopCommands_ScriptCommands_Id",
                table: "StartLoopCommands");

            migrationBuilder.DropForeignKey(
                name: "FK_SubactionHeader_Subactions_SubactionId",
                table: "SubactionHeader");

            migrationBuilder.DropForeignKey(
                name: "FK_Subactions_Characters_CharacterId",
                table: "Subactions");

            migrationBuilder.DropForeignKey(
                name: "FK_ThrowCommands_ScriptCommands_Id",
                table: "ThrowCommands");

            migrationBuilder.DropForeignKey(
                name: "FK_TimerCommands_ScriptCommands_Id",
                table: "TimerCommands");

            migrationBuilder.DropForeignKey(
                name: "FK_UnsolvedCommands_ScriptCommands_Id",
                table: "UnsolvedCommands");

            migrationBuilder.DropForeignKey(
                name: "FK_VisibilityCommands_ScriptCommands_Id",
                table: "VisibilityCommands");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subactions",
                table: "Subactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sources",
                table: "Sources");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Moves",
                table: "Moves");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hits",
                table: "Hits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hitboxes",
                table: "Hitboxes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Characters",
                table: "Characters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VisibilityCommands",
                table: "VisibilityCommands");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UnsolvedCommands",
                table: "UnsolvedCommands");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TimerCommands",
                table: "TimerCommands");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ThrowCommands",
                table: "ThrowCommands");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubactionHeader",
                table: "SubactionHeader");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StartLoopCommands",
                table: "StartLoopCommands");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ScriptCommands",
                table: "ScriptCommands");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PointerCommands",
                table: "PointerCommands");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PartialBodystateCommands",
                table: "PartialBodystateCommands");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MoveSubactions",
                table: "MoveSubactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MoveSource",
                table: "MoveSource");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HitboxCommands",
                table: "HitboxCommands");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterStatistics",
                table: "CharacterStatistics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharactersMiscInfos",
                table: "CharactersMiscInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BodyStateCommands",
                table: "BodyStateCommands");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AutoCancelCommands",
                table: "AutoCancelCommands");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AlternativeAnimations",
                table: "AlternativeAnimations");

            migrationBuilder.RenameTable(
                name: "Subactions",
                newName: "subactions");

            migrationBuilder.RenameTable(
                name: "Sources",
                newName: "sources");

            migrationBuilder.RenameTable(
                name: "Moves",
                newName: "moves");

            migrationBuilder.RenameTable(
                name: "Hits",
                newName: "hits");

            migrationBuilder.RenameTable(
                name: "Hitboxes",
                newName: "hitboxes");

            migrationBuilder.RenameTable(
                name: "Characters",
                newName: "characters");

            migrationBuilder.RenameTable(
                name: "VisibilityCommands",
                newName: "visibility_commands");

            migrationBuilder.RenameTable(
                name: "UnsolvedCommands",
                newName: "unsolved_commands");

            migrationBuilder.RenameTable(
                name: "TimerCommands",
                newName: "timer_commands");

            migrationBuilder.RenameTable(
                name: "ThrowCommands",
                newName: "throw_commands");

            migrationBuilder.RenameTable(
                name: "SubactionHeader",
                newName: "subaction_header");

            migrationBuilder.RenameTable(
                name: "StartLoopCommands",
                newName: "start_loop_commands");

            migrationBuilder.RenameTable(
                name: "ScriptCommands",
                newName: "script_commands");

            migrationBuilder.RenameTable(
                name: "PointerCommands",
                newName: "pointer_commands");

            migrationBuilder.RenameTable(
                name: "PartialBodystateCommands",
                newName: "partial_bodystate_commands");

            migrationBuilder.RenameTable(
                name: "MoveSubactions",
                newName: "move_subactions");

            migrationBuilder.RenameTable(
                name: "MoveSource",
                newName: "move_source");

            migrationBuilder.RenameTable(
                name: "HitboxCommands",
                newName: "hitbox_commands");

            migrationBuilder.RenameTable(
                name: "CharacterStatistics",
                newName: "character_statistics");

            migrationBuilder.RenameTable(
                name: "CharactersMiscInfos",
                newName: "characters_misc_infos");

            migrationBuilder.RenameTable(
                name: "BodyStateCommands",
                newName: "body_state_commands");

            migrationBuilder.RenameTable(
                name: "AutoCancelCommands",
                newName: "auto_cancel_commands");

            migrationBuilder.RenameTable(
                name: "AlternativeAnimations",
                newName: "alternative_animations");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "subactions",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Index",
                table: "subactions",
                newName: "index");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "subactions",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "CharacterId",
                table: "subactions",
                newName: "character_id");

            migrationBuilder.RenameIndex(
                name: "IX_Subactions_CharacterId",
                table: "subactions",
                newName: "ix_subactions_character_id");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "sources",
                newName: "url");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "sources",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "sources",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "moves",
                newName: "type");

            migrationBuilder.RenameColumn(
                name: "Start",
                table: "moves",
                newName: "start");

            migrationBuilder.RenameColumn(
                name: "Source",
                table: "moves",
                newName: "source");

            migrationBuilder.RenameColumn(
                name: "Percent",
                table: "moves",
                newName: "percent");

            migrationBuilder.RenameColumn(
                name: "Notes",
                table: "moves",
                newName: "notes");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "moves",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "IASA",
                table: "moves",
                newName: "iasa");

            migrationBuilder.RenameColumn(
                name: "End",
                table: "moves",
                newName: "end");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "moves",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "WebmUrl",
                table: "moves",
                newName: "webm_url");

            migrationBuilder.RenameColumn(
                name: "TotalFrames",
                table: "moves",
                newName: "total_frames");

            migrationBuilder.RenameColumn(
                name: "PngUrl",
                table: "moves",
                newName: "png_url");

            migrationBuilder.RenameColumn(
                name: "NormalizedName",
                table: "moves",
                newName: "normalized_name");

            migrationBuilder.RenameColumn(
                name: "LandingFallSpecialLag",
                table: "moves",
                newName: "landing_fall_special_lag");

            migrationBuilder.RenameColumn(
                name: "LandLag",
                table: "moves",
                newName: "land_lag");

            migrationBuilder.RenameColumn(
                name: "LCanceledLandLag",
                table: "moves",
                newName: "l_canceled_land_lag");

            migrationBuilder.RenameColumn(
                name: "IsInterpolated",
                table: "moves",
                newName: "is_interpolated");

            migrationBuilder.RenameColumn(
                name: "GifUrl",
                table: "moves",
                newName: "gif_url");

            migrationBuilder.RenameColumn(
                name: "CharacterId",
                table: "moves",
                newName: "character_id");

            migrationBuilder.RenameColumn(
                name: "AutoCancelBefore",
                table: "moves",
                newName: "auto_cancel_before");

            migrationBuilder.RenameColumn(
                name: "AutoCancelAfter",
                table: "moves",
                newName: "auto_cancel_after");

            migrationBuilder.RenameIndex(
                name: "IX_Moves_CharacterId",
                table: "moves",
                newName: "ix_moves_character_id");

            migrationBuilder.RenameColumn(
                name: "Start",
                table: "hits",
                newName: "start");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "hits",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "End",
                table: "hits",
                newName: "end");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "hits",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "MoveId",
                table: "hits",
                newName: "move_id");

            migrationBuilder.RenameIndex(
                name: "IX_Hits_MoveId",
                table: "hits",
                newName: "ix_hits_move_id");

            migrationBuilder.RenameColumn(
                name: "Shieldstun",
                table: "hitboxes",
                newName: "shieldstun");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "hitboxes",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Effect",
                table: "hitboxes",
                newName: "effect");

            migrationBuilder.RenameColumn(
                name: "Damage",
                table: "hitboxes",
                newName: "damage");

            migrationBuilder.RenameColumn(
                name: "Angle",
                table: "hitboxes",
                newName: "angle");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "hitboxes",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "YoshiArmorBreakPercentage",
                table: "hitboxes",
                newName: "yoshi_armor_break_percentage");

            migrationBuilder.RenameColumn(
                name: "SetKnockback",
                table: "hitboxes",
                newName: "set_knockback");

            migrationBuilder.RenameColumn(
                name: "KnockbackGrowth",
                table: "hitboxes",
                newName: "knockback_growth");

            migrationBuilder.RenameColumn(
                name: "IsWeightIndependent",
                table: "hitboxes",
                newName: "is_weight_independent");

            migrationBuilder.RenameColumn(
                name: "HitlagDefenderCrouched",
                table: "hitboxes",
                newName: "hitlag_defender_crouched");

            migrationBuilder.RenameColumn(
                name: "HitlagDefender",
                table: "hitboxes",
                newName: "hitlag_defender");

            migrationBuilder.RenameColumn(
                name: "HitlagAttackerCrouched",
                table: "hitboxes",
                newName: "hitlag_attacker_crouched");

            migrationBuilder.RenameColumn(
                name: "HitlagAttacker",
                table: "hitboxes",
                newName: "hitlag_attacker");

            migrationBuilder.RenameColumn(
                name: "HitId",
                table: "hitboxes",
                newName: "hit_id");

            migrationBuilder.RenameColumn(
                name: "BaseKnockback",
                table: "hitboxes",
                newName: "base_knockback");

            migrationBuilder.RenameIndex(
                name: "IX_Hitboxes_HitId",
                table: "hitboxes",
                newName: "ix_hitboxes_hit_id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "characters",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "characters",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "NormalizedName",
                table: "characters",
                newName: "normalized_name");

            migrationBuilder.RenameColumn(
                name: "FightCoreId",
                table: "characters",
                newName: "fight_core_id");

            migrationBuilder.RenameColumn(
                name: "CharacterStatisticsId",
                table: "characters",
                newName: "character_statistics_id");

            migrationBuilder.RenameColumn(
                name: "CharacterInfoId",
                table: "characters",
                newName: "character_info_id");

            migrationBuilder.RenameIndex(
                name: "IX_Characters_CharacterStatisticsId",
                table: "characters",
                newName: "ix_characters_character_statistics_id");

            migrationBuilder.RenameIndex(
                name: "IX_Characters_CharacterInfoId",
                table: "characters",
                newName: "ix_characters_character_info_id");

            migrationBuilder.RenameColumn(
                name: "Visibility",
                table: "visibility_commands",
                newName: "visibility");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "visibility_commands",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "unsolved_commands",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Frames",
                table: "timer_commands",
                newName: "frames");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "timer_commands",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Damage",
                table: "throw_commands",
                newName: "damage");

            migrationBuilder.RenameColumn(
                name: "Angle",
                table: "throw_commands",
                newName: "angle");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "throw_commands",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "WeightDependantKnockback",
                table: "throw_commands",
                newName: "weight_dependant_knockback");

            migrationBuilder.RenameColumn(
                name: "ThrowType",
                table: "throw_commands",
                newName: "throw_type");

            migrationBuilder.RenameColumn(
                name: "ThrowElement",
                table: "throw_commands",
                newName: "throw_element");

            migrationBuilder.RenameColumn(
                name: "KnockbackGrowth",
                table: "throw_commands",
                newName: "knockback_growth");

            migrationBuilder.RenameColumn(
                name: "BaseKnockback",
                table: "throw_commands",
                newName: "base_knockback");

            migrationBuilder.RenameColumn(
                name: "Unknown4Offset",
                table: "subaction_header",
                newName: "unknown4offset");

            migrationBuilder.RenameColumn(
                name: "Unknown3Flags",
                table: "subaction_header",
                newName: "unknown3flags");

            migrationBuilder.RenameColumn(
                name: "Unknown2Offset",
                table: "subaction_header",
                newName: "unknown2offset");

            migrationBuilder.RenameColumn(
                name: "Unknown1Offset",
                table: "subaction_header",
                newName: "unknown1offset");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "subaction_header",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "SubactionId",
                table: "subaction_header",
                newName: "subaction_id");

            migrationBuilder.RenameColumn(
                name: "StringOffset",
                table: "subaction_header",
                newName: "string_offset");

            migrationBuilder.RenameColumn(
                name: "ScriptOffset",
                table: "subaction_header",
                newName: "script_offset");

            migrationBuilder.RenameIndex(
                name: "IX_SubactionHeader_SubactionId",
                table: "subaction_header",
                newName: "ix_subaction_header_subaction_id");

            migrationBuilder.RenameColumn(
                name: "Iterations",
                table: "start_loop_commands",
                newName: "iterations");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "start_loop_commands",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "script_commands",
                newName: "type");

            migrationBuilder.RenameColumn(
                name: "Order",
                table: "script_commands",
                newName: "order");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "script_commands",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Length",
                table: "script_commands",
                newName: "length");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "script_commands",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "SubactionId",
                table: "script_commands",
                newName: "subaction_id");

            migrationBuilder.RenameColumn(
                name: "HexString",
                table: "script_commands",
                newName: "hex_string");

            migrationBuilder.RenameColumn(
                name: "DisplayName",
                table: "script_commands",
                newName: "display_name");

            migrationBuilder.RenameIndex(
                name: "IX_ScriptCommands_SubactionId",
                table: "script_commands",
                newName: "ix_script_commands_subaction_id");

            migrationBuilder.RenameColumn(
                name: "Pointer",
                table: "pointer_commands",
                newName: "pointer");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "pointer_commands",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Bone",
                table: "partial_bodystate_commands",
                newName: "bone");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "partial_bodystate_commands",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Frame",
                table: "move_subactions",
                newName: "frame");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "move_subactions",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "SubactionId",
                table: "move_subactions",
                newName: "subaction_id");

            migrationBuilder.RenameColumn(
                name: "MoveId",
                table: "move_subactions",
                newName: "move_id");

            migrationBuilder.RenameColumn(
                name: "MatchType",
                table: "move_subactions",
                newName: "match_type");

            migrationBuilder.RenameIndex(
                name: "IX_MoveSubactions_SubactionId",
                table: "move_subactions",
                newName: "ix_move_subactions_subaction_id");

            migrationBuilder.RenameIndex(
                name: "IX_MoveSubactions_MoveId",
                table: "move_subactions",
                newName: "ix_move_subactions_move_id");

            migrationBuilder.RenameColumn(
                name: "SourcesId",
                table: "move_source",
                newName: "sources_id");

            migrationBuilder.RenameColumn(
                name: "MovesId",
                table: "move_source",
                newName: "moves_id");

            migrationBuilder.RenameIndex(
                name: "IX_MoveSource_SourcesId",
                table: "move_source",
                newName: "ix_move_source_sources_id");

            migrationBuilder.RenameColumn(
                name: "Unknown0",
                table: "hitbox_commands",
                newName: "unknown0");

            migrationBuilder.RenameColumn(
                name: "Size",
                table: "hitbox_commands",
                newName: "size");

            migrationBuilder.RenameColumn(
                name: "SFX",
                table: "hitbox_commands",
                newName: "sfx");

            migrationBuilder.RenameColumn(
                name: "Element",
                table: "hitbox_commands",
                newName: "element");

            migrationBuilder.RenameColumn(
                name: "Damage",
                table: "hitbox_commands",
                newName: "damage");

            migrationBuilder.RenameColumn(
                name: "Angle",
                table: "hitbox_commands",
                newName: "angle");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "hitbox_commands",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "ZOffset",
                table: "hitbox_commands",
                newName: "z_offset");

            migrationBuilder.RenameColumn(
                name: "YOffset",
                table: "hitbox_commands",
                newName: "y_offset");

            migrationBuilder.RenameColumn(
                name: "XOffset",
                table: "hitbox_commands",
                newName: "x_offset");

            migrationBuilder.RenameColumn(
                name: "WeightDependantKnockback",
                table: "hitbox_commands",
                newName: "weight_dependant_knockback");

            migrationBuilder.RenameColumn(
                name: "UnknownV",
                table: "hitbox_commands",
                newName: "unknown_v");

            migrationBuilder.RenameColumn(
                name: "UnknownR",
                table: "hitbox_commands",
                newName: "unknown_r");

            migrationBuilder.RenameColumn(
                name: "UnknownQ",
                table: "hitbox_commands",
                newName: "unknown_q");

            migrationBuilder.RenameColumn(
                name: "ShieldDamage",
                table: "hitbox_commands",
                newName: "shield_damage");

            migrationBuilder.RenameColumn(
                name: "KnockbackGrowth",
                table: "hitbox_commands",
                newName: "knockback_growth");

            migrationBuilder.RenameColumn(
                name: "HurtboxInteraction",
                table: "hitbox_commands",
                newName: "hurtbox_interaction");

            migrationBuilder.RenameColumn(
                name: "HitsGround",
                table: "hitbox_commands",
                newName: "hits_ground");

            migrationBuilder.RenameColumn(
                name: "HitsAir",
                table: "hitbox_commands",
                newName: "hits_air");

            migrationBuilder.RenameColumn(
                name: "HitboxId",
                table: "hitbox_commands",
                newName: "hitbox_id");

            migrationBuilder.RenameColumn(
                name: "BoneId",
                table: "hitbox_commands",
                newName: "bone_id");

            migrationBuilder.RenameColumn(
                name: "BaseKnockback",
                table: "hitbox_commands",
                newName: "base_knockback");

            migrationBuilder.RenameColumn(
                name: "Weight",
                table: "character_statistics",
                newName: "weight");

            migrationBuilder.RenameColumn(
                name: "Notes",
                table: "character_statistics",
                newName: "notes");

            migrationBuilder.RenameColumn(
                name: "Gravity",
                table: "character_statistics",
                newName: "gravity");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "character_statistics",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "WaveDashLengthRank",
                table: "character_statistics",
                newName: "wave_dash_length_rank");

            migrationBuilder.RenameColumn(
                name: "WaveDashLength",
                table: "character_statistics",
                newName: "wave_dash_length");

            migrationBuilder.RenameColumn(
                name: "WalkSpeed",
                table: "character_statistics",
                newName: "walk_speed");

            migrationBuilder.RenameColumn(
                name: "RunSpeed",
                table: "character_statistics",
                newName: "run_speed");

            migrationBuilder.RenameColumn(
                name: "PLAIntangibilityFrames",
                table: "character_statistics",
                newName: "pla_intangibility_frames");

            migrationBuilder.RenameColumn(
                name: "JumpSquat",
                table: "character_statistics",
                newName: "jump_squat");

            migrationBuilder.RenameColumn(
                name: "InitialDash",
                table: "character_statistics",
                newName: "initial_dash");

            migrationBuilder.RenameColumn(
                name: "DashFrames",
                table: "character_statistics",
                newName: "dash_frames");

            migrationBuilder.RenameColumn(
                name: "CanWallJump",
                table: "character_statistics",
                newName: "can_wall_jump");

            migrationBuilder.RenameColumn(
                name: "Discord",
                table: "characters_misc_infos",
                newName: "discord");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "characters_misc_infos",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "SsbWiki",
                table: "characters_misc_infos",
                newName: "ssb_wiki");

            migrationBuilder.RenameColumn(
                name: "MeleeFrameData",
                table: "characters_misc_infos",
                newName: "melee_frame_data");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "body_state_commands",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "BodyType",
                table: "body_state_commands",
                newName: "body_type");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "auto_cancel_commands",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "AutoCancelEnabled",
                table: "auto_cancel_commands",
                newName: "auto_cancel_enabled");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "alternative_animations",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "alternative_animations",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "WebmUrl",
                table: "alternative_animations",
                newName: "webm_url");

            migrationBuilder.RenameColumn(
                name: "PngUrl",
                table: "alternative_animations",
                newName: "png_url");

            migrationBuilder.RenameColumn(
                name: "MoveId",
                table: "alternative_animations",
                newName: "move_id");

            migrationBuilder.RenameColumn(
                name: "GifUrl",
                table: "alternative_animations",
                newName: "gif_url");

            migrationBuilder.RenameIndex(
                name: "IX_AlternativeAnimations_MoveId",
                table: "alternative_animations",
                newName: "ix_alternative_animations_move_id");

            migrationBuilder.AlterColumn<long>(
                name: "hit_id",
                table: "hitboxes",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "pk_subactions",
                table: "subactions",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_sources",
                table: "sources",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_moves",
                table: "moves",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_hits",
                table: "hits",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_hitboxes",
                table: "hitboxes",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_characters",
                table: "characters",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_visibility_commands",
                table: "visibility_commands",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_unsolved_commands",
                table: "unsolved_commands",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_timer_commands",
                table: "timer_commands",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_throw_commands",
                table: "throw_commands",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_subaction_header",
                table: "subaction_header",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_start_loop_commands",
                table: "start_loop_commands",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_script_commands",
                table: "script_commands",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pointer_commands",
                table: "pointer_commands",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_partial_bodystate_commands",
                table: "partial_bodystate_commands",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_move_subactions",
                table: "move_subactions",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_move_source",
                table: "move_source",
                columns: new[] { "moves_id", "sources_id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_hitbox_commands",
                table: "hitbox_commands",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_character_statistics",
                table: "character_statistics",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_characters_misc_infos",
                table: "characters_misc_infos",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_body_state_commands",
                table: "body_state_commands",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_auto_cancel_commands",
                table: "auto_cancel_commands",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_alternative_animations",
                table: "alternative_animations",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_alternative_animations_moves_move_id",
                table: "alternative_animations",
                column: "move_id",
                principalTable: "moves",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_auto_cancel_commands_script_commands_id",
                table: "auto_cancel_commands",
                column: "id",
                principalTable: "script_commands",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_body_state_commands_script_commands_id",
                table: "body_state_commands",
                column: "id",
                principalTable: "script_commands",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_characters_character_statistics_character_statistics_id",
                table: "characters",
                column: "character_statistics_id",
                principalTable: "character_statistics",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_characters_characters_misc_infos_character_info_id",
                table: "characters",
                column: "character_info_id",
                principalTable: "characters_misc_infos",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_hitbox_commands_script_commands_id",
                table: "hitbox_commands",
                column: "id",
                principalTable: "script_commands",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_hitboxes_hits_hit_id",
                table: "hitboxes",
                column: "hit_id",
                principalTable: "hits",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_hits_moves_move_id",
                table: "hits",
                column: "move_id",
                principalTable: "moves",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_move_source_moves_moves_id",
                table: "move_source",
                column: "moves_id",
                principalTable: "moves",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_move_source_sources_sources_id",
                table: "move_source",
                column: "sources_id",
                principalTable: "sources",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_move_subactions_moves_move_id",
                table: "move_subactions",
                column: "move_id",
                principalTable: "moves",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_move_subactions_subactions_subaction_id",
                table: "move_subactions",
                column: "subaction_id",
                principalTable: "subactions",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_moves_characters_character_id",
                table: "moves",
                column: "character_id",
                principalTable: "characters",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_partial_bodystate_commands_script_commands_id",
                table: "partial_bodystate_commands",
                column: "id",
                principalTable: "script_commands",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_pointer_commands_script_commands_id",
                table: "pointer_commands",
                column: "id",
                principalTable: "script_commands",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_script_commands_subactions_subaction_id",
                table: "script_commands",
                column: "subaction_id",
                principalTable: "subactions",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_start_loop_commands_script_commands_id",
                table: "start_loop_commands",
                column: "id",
                principalTable: "script_commands",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_subaction_header_subactions_subaction_id",
                table: "subaction_header",
                column: "subaction_id",
                principalTable: "subactions",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_subactions_characters_character_id",
                table: "subactions",
                column: "character_id",
                principalTable: "characters",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_throw_commands_script_commands_id",
                table: "throw_commands",
                column: "id",
                principalTable: "script_commands",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_timer_commands_script_commands_id",
                table: "timer_commands",
                column: "id",
                principalTable: "script_commands",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_unsolved_commands_script_commands_id",
                table: "unsolved_commands",
                column: "id",
                principalTable: "script_commands",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_visibility_commands_script_commands_id",
                table: "visibility_commands",
                column: "id",
                principalTable: "script_commands",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_alternative_animations_moves_move_id",
                table: "alternative_animations");

            migrationBuilder.DropForeignKey(
                name: "fk_auto_cancel_commands_script_commands_id",
                table: "auto_cancel_commands");

            migrationBuilder.DropForeignKey(
                name: "fk_body_state_commands_script_commands_id",
                table: "body_state_commands");

            migrationBuilder.DropForeignKey(
                name: "fk_characters_character_statistics_character_statistics_id",
                table: "characters");

            migrationBuilder.DropForeignKey(
                name: "fk_characters_characters_misc_infos_character_info_id",
                table: "characters");

            migrationBuilder.DropForeignKey(
                name: "fk_hitbox_commands_script_commands_id",
                table: "hitbox_commands");

            migrationBuilder.DropForeignKey(
                name: "fk_hitboxes_hits_hit_id",
                table: "hitboxes");

            migrationBuilder.DropForeignKey(
                name: "fk_hits_moves_move_id",
                table: "hits");

            migrationBuilder.DropForeignKey(
                name: "fk_move_source_moves_moves_id",
                table: "move_source");

            migrationBuilder.DropForeignKey(
                name: "fk_move_source_sources_sources_id",
                table: "move_source");

            migrationBuilder.DropForeignKey(
                name: "fk_move_subactions_moves_move_id",
                table: "move_subactions");

            migrationBuilder.DropForeignKey(
                name: "fk_move_subactions_subactions_subaction_id",
                table: "move_subactions");

            migrationBuilder.DropForeignKey(
                name: "fk_moves_characters_character_id",
                table: "moves");

            migrationBuilder.DropForeignKey(
                name: "fk_partial_bodystate_commands_script_commands_id",
                table: "partial_bodystate_commands");

            migrationBuilder.DropForeignKey(
                name: "fk_pointer_commands_script_commands_id",
                table: "pointer_commands");

            migrationBuilder.DropForeignKey(
                name: "fk_script_commands_subactions_subaction_id",
                table: "script_commands");

            migrationBuilder.DropForeignKey(
                name: "fk_start_loop_commands_script_commands_id",
                table: "start_loop_commands");

            migrationBuilder.DropForeignKey(
                name: "fk_subaction_header_subactions_subaction_id",
                table: "subaction_header");

            migrationBuilder.DropForeignKey(
                name: "fk_subactions_characters_character_id",
                table: "subactions");

            migrationBuilder.DropForeignKey(
                name: "fk_throw_commands_script_commands_id",
                table: "throw_commands");

            migrationBuilder.DropForeignKey(
                name: "fk_timer_commands_script_commands_id",
                table: "timer_commands");

            migrationBuilder.DropForeignKey(
                name: "fk_unsolved_commands_script_commands_id",
                table: "unsolved_commands");

            migrationBuilder.DropForeignKey(
                name: "fk_visibility_commands_script_commands_id",
                table: "visibility_commands");

            migrationBuilder.DropPrimaryKey(
                name: "pk_subactions",
                table: "subactions");

            migrationBuilder.DropPrimaryKey(
                name: "pk_sources",
                table: "sources");

            migrationBuilder.DropPrimaryKey(
                name: "pk_moves",
                table: "moves");

            migrationBuilder.DropPrimaryKey(
                name: "pk_hits",
                table: "hits");

            migrationBuilder.DropPrimaryKey(
                name: "pk_hitboxes",
                table: "hitboxes");

            migrationBuilder.DropPrimaryKey(
                name: "pk_characters",
                table: "characters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_visibility_commands",
                table: "visibility_commands");

            migrationBuilder.DropPrimaryKey(
                name: "PK_unsolved_commands",
                table: "unsolved_commands");

            migrationBuilder.DropPrimaryKey(
                name: "PK_timer_commands",
                table: "timer_commands");

            migrationBuilder.DropPrimaryKey(
                name: "PK_throw_commands",
                table: "throw_commands");

            migrationBuilder.DropPrimaryKey(
                name: "pk_subaction_header",
                table: "subaction_header");

            migrationBuilder.DropPrimaryKey(
                name: "PK_start_loop_commands",
                table: "start_loop_commands");

            migrationBuilder.DropPrimaryKey(
                name: "PK_script_commands",
                table: "script_commands");

            migrationBuilder.DropPrimaryKey(
                name: "PK_pointer_commands",
                table: "pointer_commands");

            migrationBuilder.DropPrimaryKey(
                name: "PK_partial_bodystate_commands",
                table: "partial_bodystate_commands");

            migrationBuilder.DropPrimaryKey(
                name: "pk_move_subactions",
                table: "move_subactions");

            migrationBuilder.DropPrimaryKey(
                name: "pk_move_source",
                table: "move_source");

            migrationBuilder.DropPrimaryKey(
                name: "PK_hitbox_commands",
                table: "hitbox_commands");

            migrationBuilder.DropPrimaryKey(
                name: "pk_characters_misc_infos",
                table: "characters_misc_infos");

            migrationBuilder.DropPrimaryKey(
                name: "pk_character_statistics",
                table: "character_statistics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_body_state_commands",
                table: "body_state_commands");

            migrationBuilder.DropPrimaryKey(
                name: "PK_auto_cancel_commands",
                table: "auto_cancel_commands");

            migrationBuilder.DropPrimaryKey(
                name: "pk_alternative_animations",
                table: "alternative_animations");

            migrationBuilder.RenameTable(
                name: "subactions",
                newName: "Subactions");

            migrationBuilder.RenameTable(
                name: "sources",
                newName: "Sources");

            migrationBuilder.RenameTable(
                name: "moves",
                newName: "Moves");

            migrationBuilder.RenameTable(
                name: "hits",
                newName: "Hits");

            migrationBuilder.RenameTable(
                name: "hitboxes",
                newName: "Hitboxes");

            migrationBuilder.RenameTable(
                name: "characters",
                newName: "Characters");

            migrationBuilder.RenameTable(
                name: "visibility_commands",
                newName: "VisibilityCommands");

            migrationBuilder.RenameTable(
                name: "unsolved_commands",
                newName: "UnsolvedCommands");

            migrationBuilder.RenameTable(
                name: "timer_commands",
                newName: "TimerCommands");

            migrationBuilder.RenameTable(
                name: "throw_commands",
                newName: "ThrowCommands");

            migrationBuilder.RenameTable(
                name: "subaction_header",
                newName: "SubactionHeader");

            migrationBuilder.RenameTable(
                name: "start_loop_commands",
                newName: "StartLoopCommands");

            migrationBuilder.RenameTable(
                name: "script_commands",
                newName: "ScriptCommands");

            migrationBuilder.RenameTable(
                name: "pointer_commands",
                newName: "PointerCommands");

            migrationBuilder.RenameTable(
                name: "partial_bodystate_commands",
                newName: "PartialBodystateCommands");

            migrationBuilder.RenameTable(
                name: "move_subactions",
                newName: "MoveSubactions");

            migrationBuilder.RenameTable(
                name: "move_source",
                newName: "MoveSource");

            migrationBuilder.RenameTable(
                name: "hitbox_commands",
                newName: "HitboxCommands");

            migrationBuilder.RenameTable(
                name: "characters_misc_infos",
                newName: "CharactersMiscInfos");

            migrationBuilder.RenameTable(
                name: "character_statistics",
                newName: "CharacterStatistics");

            migrationBuilder.RenameTable(
                name: "body_state_commands",
                newName: "BodyStateCommands");

            migrationBuilder.RenameTable(
                name: "auto_cancel_commands",
                newName: "AutoCancelCommands");

            migrationBuilder.RenameTable(
                name: "alternative_animations",
                newName: "AlternativeAnimations");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Subactions",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "index",
                table: "Subactions",
                newName: "Index");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Subactions",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "character_id",
                table: "Subactions",
                newName: "CharacterId");

            migrationBuilder.RenameIndex(
                name: "ix_subactions_character_id",
                table: "Subactions",
                newName: "IX_Subactions_CharacterId");

            migrationBuilder.RenameColumn(
                name: "url",
                table: "Sources",
                newName: "Url");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Sources",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Sources",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "type",
                table: "Moves",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "start",
                table: "Moves",
                newName: "Start");

            migrationBuilder.RenameColumn(
                name: "source",
                table: "Moves",
                newName: "Source");

            migrationBuilder.RenameColumn(
                name: "percent",
                table: "Moves",
                newName: "Percent");

            migrationBuilder.RenameColumn(
                name: "notes",
                table: "Moves",
                newName: "Notes");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Moves",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "iasa",
                table: "Moves",
                newName: "IASA");

            migrationBuilder.RenameColumn(
                name: "end",
                table: "Moves",
                newName: "End");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Moves",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "webm_url",
                table: "Moves",
                newName: "WebmUrl");

            migrationBuilder.RenameColumn(
                name: "total_frames",
                table: "Moves",
                newName: "TotalFrames");

            migrationBuilder.RenameColumn(
                name: "png_url",
                table: "Moves",
                newName: "PngUrl");

            migrationBuilder.RenameColumn(
                name: "normalized_name",
                table: "Moves",
                newName: "NormalizedName");

            migrationBuilder.RenameColumn(
                name: "landing_fall_special_lag",
                table: "Moves",
                newName: "LandingFallSpecialLag");

            migrationBuilder.RenameColumn(
                name: "land_lag",
                table: "Moves",
                newName: "LandLag");

            migrationBuilder.RenameColumn(
                name: "l_canceled_land_lag",
                table: "Moves",
                newName: "LCanceledLandLag");

            migrationBuilder.RenameColumn(
                name: "is_interpolated",
                table: "Moves",
                newName: "IsInterpolated");

            migrationBuilder.RenameColumn(
                name: "gif_url",
                table: "Moves",
                newName: "GifUrl");

            migrationBuilder.RenameColumn(
                name: "character_id",
                table: "Moves",
                newName: "CharacterId");

            migrationBuilder.RenameColumn(
                name: "auto_cancel_before",
                table: "Moves",
                newName: "AutoCancelBefore");

            migrationBuilder.RenameColumn(
                name: "auto_cancel_after",
                table: "Moves",
                newName: "AutoCancelAfter");

            migrationBuilder.RenameIndex(
                name: "ix_moves_character_id",
                table: "Moves",
                newName: "IX_Moves_CharacterId");

            migrationBuilder.RenameColumn(
                name: "start",
                table: "Hits",
                newName: "Start");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Hits",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "end",
                table: "Hits",
                newName: "End");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Hits",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "move_id",
                table: "Hits",
                newName: "MoveId");

            migrationBuilder.RenameIndex(
                name: "ix_hits_move_id",
                table: "Hits",
                newName: "IX_Hits_MoveId");

            migrationBuilder.RenameColumn(
                name: "shieldstun",
                table: "Hitboxes",
                newName: "Shieldstun");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Hitboxes",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "effect",
                table: "Hitboxes",
                newName: "Effect");

            migrationBuilder.RenameColumn(
                name: "damage",
                table: "Hitboxes",
                newName: "Damage");

            migrationBuilder.RenameColumn(
                name: "angle",
                table: "Hitboxes",
                newName: "Angle");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Hitboxes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "yoshi_armor_break_percentage",
                table: "Hitboxes",
                newName: "YoshiArmorBreakPercentage");

            migrationBuilder.RenameColumn(
                name: "set_knockback",
                table: "Hitboxes",
                newName: "SetKnockback");

            migrationBuilder.RenameColumn(
                name: "knockback_growth",
                table: "Hitboxes",
                newName: "KnockbackGrowth");

            migrationBuilder.RenameColumn(
                name: "is_weight_independent",
                table: "Hitboxes",
                newName: "IsWeightIndependent");

            migrationBuilder.RenameColumn(
                name: "hitlag_defender_crouched",
                table: "Hitboxes",
                newName: "HitlagDefenderCrouched");

            migrationBuilder.RenameColumn(
                name: "hitlag_defender",
                table: "Hitboxes",
                newName: "HitlagDefender");

            migrationBuilder.RenameColumn(
                name: "hitlag_attacker_crouched",
                table: "Hitboxes",
                newName: "HitlagAttackerCrouched");

            migrationBuilder.RenameColumn(
                name: "hitlag_attacker",
                table: "Hitboxes",
                newName: "HitlagAttacker");

            migrationBuilder.RenameColumn(
                name: "hit_id",
                table: "Hitboxes",
                newName: "HitId");

            migrationBuilder.RenameColumn(
                name: "base_knockback",
                table: "Hitboxes",
                newName: "BaseKnockback");

            migrationBuilder.RenameIndex(
                name: "ix_hitboxes_hit_id",
                table: "Hitboxes",
                newName: "IX_Hitboxes_HitId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Characters",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Characters",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "normalized_name",
                table: "Characters",
                newName: "NormalizedName");

            migrationBuilder.RenameColumn(
                name: "fight_core_id",
                table: "Characters",
                newName: "FightCoreId");

            migrationBuilder.RenameColumn(
                name: "character_statistics_id",
                table: "Characters",
                newName: "CharacterStatisticsId");

            migrationBuilder.RenameColumn(
                name: "character_info_id",
                table: "Characters",
                newName: "CharacterInfoId");

            migrationBuilder.RenameIndex(
                name: "ix_characters_character_statistics_id",
                table: "Characters",
                newName: "IX_Characters_CharacterStatisticsId");

            migrationBuilder.RenameIndex(
                name: "ix_characters_character_info_id",
                table: "Characters",
                newName: "IX_Characters_CharacterInfoId");

            migrationBuilder.RenameColumn(
                name: "visibility",
                table: "VisibilityCommands",
                newName: "Visibility");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "VisibilityCommands",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "UnsolvedCommands",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "frames",
                table: "TimerCommands",
                newName: "Frames");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "TimerCommands",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "damage",
                table: "ThrowCommands",
                newName: "Damage");

            migrationBuilder.RenameColumn(
                name: "angle",
                table: "ThrowCommands",
                newName: "Angle");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "ThrowCommands",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "weight_dependant_knockback",
                table: "ThrowCommands",
                newName: "WeightDependantKnockback");

            migrationBuilder.RenameColumn(
                name: "throw_type",
                table: "ThrowCommands",
                newName: "ThrowType");

            migrationBuilder.RenameColumn(
                name: "throw_element",
                table: "ThrowCommands",
                newName: "ThrowElement");

            migrationBuilder.RenameColumn(
                name: "knockback_growth",
                table: "ThrowCommands",
                newName: "KnockbackGrowth");

            migrationBuilder.RenameColumn(
                name: "base_knockback",
                table: "ThrowCommands",
                newName: "BaseKnockback");

            migrationBuilder.RenameColumn(
                name: "unknown4offset",
                table: "SubactionHeader",
                newName: "Unknown4Offset");

            migrationBuilder.RenameColumn(
                name: "unknown3flags",
                table: "SubactionHeader",
                newName: "Unknown3Flags");

            migrationBuilder.RenameColumn(
                name: "unknown2offset",
                table: "SubactionHeader",
                newName: "Unknown2Offset");

            migrationBuilder.RenameColumn(
                name: "unknown1offset",
                table: "SubactionHeader",
                newName: "Unknown1Offset");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "SubactionHeader",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "subaction_id",
                table: "SubactionHeader",
                newName: "SubactionId");

            migrationBuilder.RenameColumn(
                name: "string_offset",
                table: "SubactionHeader",
                newName: "StringOffset");

            migrationBuilder.RenameColumn(
                name: "script_offset",
                table: "SubactionHeader",
                newName: "ScriptOffset");

            migrationBuilder.RenameIndex(
                name: "ix_subaction_header_subaction_id",
                table: "SubactionHeader",
                newName: "IX_SubactionHeader_SubactionId");

            migrationBuilder.RenameColumn(
                name: "iterations",
                table: "StartLoopCommands",
                newName: "Iterations");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "StartLoopCommands",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "type",
                table: "ScriptCommands",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "order",
                table: "ScriptCommands",
                newName: "Order");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "ScriptCommands",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "length",
                table: "ScriptCommands",
                newName: "Length");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "ScriptCommands",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "subaction_id",
                table: "ScriptCommands",
                newName: "SubactionId");

            migrationBuilder.RenameColumn(
                name: "hex_string",
                table: "ScriptCommands",
                newName: "HexString");

            migrationBuilder.RenameColumn(
                name: "display_name",
                table: "ScriptCommands",
                newName: "DisplayName");

            migrationBuilder.RenameIndex(
                name: "ix_script_commands_subaction_id",
                table: "ScriptCommands",
                newName: "IX_ScriptCommands_SubactionId");

            migrationBuilder.RenameColumn(
                name: "pointer",
                table: "PointerCommands",
                newName: "Pointer");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "PointerCommands",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "bone",
                table: "PartialBodystateCommands",
                newName: "Bone");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "PartialBodystateCommands",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "frame",
                table: "MoveSubactions",
                newName: "Frame");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "MoveSubactions",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "subaction_id",
                table: "MoveSubactions",
                newName: "SubactionId");

            migrationBuilder.RenameColumn(
                name: "move_id",
                table: "MoveSubactions",
                newName: "MoveId");

            migrationBuilder.RenameColumn(
                name: "match_type",
                table: "MoveSubactions",
                newName: "MatchType");

            migrationBuilder.RenameIndex(
                name: "ix_move_subactions_subaction_id",
                table: "MoveSubactions",
                newName: "IX_MoveSubactions_SubactionId");

            migrationBuilder.RenameIndex(
                name: "ix_move_subactions_move_id",
                table: "MoveSubactions",
                newName: "IX_MoveSubactions_MoveId");

            migrationBuilder.RenameColumn(
                name: "sources_id",
                table: "MoveSource",
                newName: "SourcesId");

            migrationBuilder.RenameColumn(
                name: "moves_id",
                table: "MoveSource",
                newName: "MovesId");

            migrationBuilder.RenameIndex(
                name: "ix_move_source_sources_id",
                table: "MoveSource",
                newName: "IX_MoveSource_SourcesId");

            migrationBuilder.RenameColumn(
                name: "unknown0",
                table: "HitboxCommands",
                newName: "Unknown0");

            migrationBuilder.RenameColumn(
                name: "size",
                table: "HitboxCommands",
                newName: "Size");

            migrationBuilder.RenameColumn(
                name: "sfx",
                table: "HitboxCommands",
                newName: "SFX");

            migrationBuilder.RenameColumn(
                name: "element",
                table: "HitboxCommands",
                newName: "Element");

            migrationBuilder.RenameColumn(
                name: "damage",
                table: "HitboxCommands",
                newName: "Damage");

            migrationBuilder.RenameColumn(
                name: "angle",
                table: "HitboxCommands",
                newName: "Angle");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "HitboxCommands",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "z_offset",
                table: "HitboxCommands",
                newName: "ZOffset");

            migrationBuilder.RenameColumn(
                name: "y_offset",
                table: "HitboxCommands",
                newName: "YOffset");

            migrationBuilder.RenameColumn(
                name: "x_offset",
                table: "HitboxCommands",
                newName: "XOffset");

            migrationBuilder.RenameColumn(
                name: "weight_dependant_knockback",
                table: "HitboxCommands",
                newName: "WeightDependantKnockback");

            migrationBuilder.RenameColumn(
                name: "unknown_v",
                table: "HitboxCommands",
                newName: "UnknownV");

            migrationBuilder.RenameColumn(
                name: "unknown_r",
                table: "HitboxCommands",
                newName: "UnknownR");

            migrationBuilder.RenameColumn(
                name: "unknown_q",
                table: "HitboxCommands",
                newName: "UnknownQ");

            migrationBuilder.RenameColumn(
                name: "shield_damage",
                table: "HitboxCommands",
                newName: "ShieldDamage");

            migrationBuilder.RenameColumn(
                name: "knockback_growth",
                table: "HitboxCommands",
                newName: "KnockbackGrowth");

            migrationBuilder.RenameColumn(
                name: "hurtbox_interaction",
                table: "HitboxCommands",
                newName: "HurtboxInteraction");

            migrationBuilder.RenameColumn(
                name: "hits_ground",
                table: "HitboxCommands",
                newName: "HitsGround");

            migrationBuilder.RenameColumn(
                name: "hits_air",
                table: "HitboxCommands",
                newName: "HitsAir");

            migrationBuilder.RenameColumn(
                name: "hitbox_id",
                table: "HitboxCommands",
                newName: "HitboxId");

            migrationBuilder.RenameColumn(
                name: "bone_id",
                table: "HitboxCommands",
                newName: "BoneId");

            migrationBuilder.RenameColumn(
                name: "base_knockback",
                table: "HitboxCommands",
                newName: "BaseKnockback");

            migrationBuilder.RenameColumn(
                name: "discord",
                table: "CharactersMiscInfos",
                newName: "Discord");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "CharactersMiscInfos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ssb_wiki",
                table: "CharactersMiscInfos",
                newName: "SsbWiki");

            migrationBuilder.RenameColumn(
                name: "melee_frame_data",
                table: "CharactersMiscInfos",
                newName: "MeleeFrameData");

            migrationBuilder.RenameColumn(
                name: "weight",
                table: "CharacterStatistics",
                newName: "Weight");

            migrationBuilder.RenameColumn(
                name: "notes",
                table: "CharacterStatistics",
                newName: "Notes");

            migrationBuilder.RenameColumn(
                name: "gravity",
                table: "CharacterStatistics",
                newName: "Gravity");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "CharacterStatistics",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "wave_dash_length_rank",
                table: "CharacterStatistics",
                newName: "WaveDashLengthRank");

            migrationBuilder.RenameColumn(
                name: "wave_dash_length",
                table: "CharacterStatistics",
                newName: "WaveDashLength");

            migrationBuilder.RenameColumn(
                name: "walk_speed",
                table: "CharacterStatistics",
                newName: "WalkSpeed");

            migrationBuilder.RenameColumn(
                name: "run_speed",
                table: "CharacterStatistics",
                newName: "RunSpeed");

            migrationBuilder.RenameColumn(
                name: "pla_intangibility_frames",
                table: "CharacterStatistics",
                newName: "PLAIntangibilityFrames");

            migrationBuilder.RenameColumn(
                name: "jump_squat",
                table: "CharacterStatistics",
                newName: "JumpSquat");

            migrationBuilder.RenameColumn(
                name: "initial_dash",
                table: "CharacterStatistics",
                newName: "InitialDash");

            migrationBuilder.RenameColumn(
                name: "dash_frames",
                table: "CharacterStatistics",
                newName: "DashFrames");

            migrationBuilder.RenameColumn(
                name: "can_wall_jump",
                table: "CharacterStatistics",
                newName: "CanWallJump");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "BodyStateCommands",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "body_type",
                table: "BodyStateCommands",
                newName: "BodyType");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "AutoCancelCommands",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "auto_cancel_enabled",
                table: "AutoCancelCommands",
                newName: "AutoCancelEnabled");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "AlternativeAnimations",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "AlternativeAnimations",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "webm_url",
                table: "AlternativeAnimations",
                newName: "WebmUrl");

            migrationBuilder.RenameColumn(
                name: "png_url",
                table: "AlternativeAnimations",
                newName: "PngUrl");

            migrationBuilder.RenameColumn(
                name: "move_id",
                table: "AlternativeAnimations",
                newName: "MoveId");

            migrationBuilder.RenameColumn(
                name: "gif_url",
                table: "AlternativeAnimations",
                newName: "GifUrl");

            migrationBuilder.RenameIndex(
                name: "ix_alternative_animations_move_id",
                table: "AlternativeAnimations",
                newName: "IX_AlternativeAnimations_MoveId");

            migrationBuilder.AlterColumn<long>(
                name: "HitId",
                table: "Hitboxes",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subactions",
                table: "Subactions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sources",
                table: "Sources",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Moves",
                table: "Moves",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hits",
                table: "Hits",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hitboxes",
                table: "Hitboxes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Characters",
                table: "Characters",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VisibilityCommands",
                table: "VisibilityCommands",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UnsolvedCommands",
                table: "UnsolvedCommands",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TimerCommands",
                table: "TimerCommands",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ThrowCommands",
                table: "ThrowCommands",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubactionHeader",
                table: "SubactionHeader",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StartLoopCommands",
                table: "StartLoopCommands",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ScriptCommands",
                table: "ScriptCommands",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PointerCommands",
                table: "PointerCommands",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PartialBodystateCommands",
                table: "PartialBodystateCommands",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MoveSubactions",
                table: "MoveSubactions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MoveSource",
                table: "MoveSource",
                columns: new[] { "MovesId", "SourcesId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_HitboxCommands",
                table: "HitboxCommands",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharactersMiscInfos",
                table: "CharactersMiscInfos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterStatistics",
                table: "CharacterStatistics",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BodyStateCommands",
                table: "BodyStateCommands",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AutoCancelCommands",
                table: "AutoCancelCommands",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AlternativeAnimations",
                table: "AlternativeAnimations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AlternativeAnimations_Moves_MoveId",
                table: "AlternativeAnimations",
                column: "MoveId",
                principalTable: "Moves",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AutoCancelCommands_ScriptCommands_Id",
                table: "AutoCancelCommands",
                column: "Id",
                principalTable: "ScriptCommands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BodyStateCommands_ScriptCommands_Id",
                table: "BodyStateCommands",
                column: "Id",
                principalTable: "ScriptCommands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_CharacterStatistics_CharacterStatisticsId",
                table: "Characters",
                column: "CharacterStatisticsId",
                principalTable: "CharacterStatistics",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_CharactersMiscInfos_CharacterInfoId",
                table: "Characters",
                column: "CharacterInfoId",
                principalTable: "CharactersMiscInfos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HitboxCommands_ScriptCommands_Id",
                table: "HitboxCommands",
                column: "Id",
                principalTable: "ScriptCommands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hitboxes_Hits_HitId",
                table: "Hitboxes",
                column: "HitId",
                principalTable: "Hits",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Hits_Moves_MoveId",
                table: "Hits",
                column: "MoveId",
                principalTable: "Moves",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Moves_Characters_CharacterId",
                table: "Moves",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MoveSource_Moves_MovesId",
                table: "MoveSource",
                column: "MovesId",
                principalTable: "Moves",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MoveSource_Sources_SourcesId",
                table: "MoveSource",
                column: "SourcesId",
                principalTable: "Sources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MoveSubactions_Moves_MoveId",
                table: "MoveSubactions",
                column: "MoveId",
                principalTable: "Moves",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MoveSubactions_Subactions_SubactionId",
                table: "MoveSubactions",
                column: "SubactionId",
                principalTable: "Subactions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartialBodystateCommands_ScriptCommands_Id",
                table: "PartialBodystateCommands",
                column: "Id",
                principalTable: "ScriptCommands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PointerCommands_ScriptCommands_Id",
                table: "PointerCommands",
                column: "Id",
                principalTable: "ScriptCommands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ScriptCommands_Subactions_SubactionId",
                table: "ScriptCommands",
                column: "SubactionId",
                principalTable: "Subactions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StartLoopCommands_ScriptCommands_Id",
                table: "StartLoopCommands",
                column: "Id",
                principalTable: "ScriptCommands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubactionHeader_Subactions_SubactionId",
                table: "SubactionHeader",
                column: "SubactionId",
                principalTable: "Subactions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subactions_Characters_CharacterId",
                table: "Subactions",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ThrowCommands_ScriptCommands_Id",
                table: "ThrowCommands",
                column: "Id",
                principalTable: "ScriptCommands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TimerCommands_ScriptCommands_Id",
                table: "TimerCommands",
                column: "Id",
                principalTable: "ScriptCommands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UnsolvedCommands_ScriptCommands_Id",
                table: "UnsolvedCommands",
                column: "Id",
                principalTable: "ScriptCommands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VisibilityCommands_ScriptCommands_Id",
                table: "VisibilityCommands",
                column: "Id",
                principalTable: "ScriptCommands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
