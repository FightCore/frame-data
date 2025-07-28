WITH "MissingAerialHitboxes" AS (
    SELECT M."Id"
    FROM "Moves" M
    LEFT JOIN "Hits" H on M."Id" = H."MoveId"
    LEFT JOIN "Hitboxes" Hb ON H."Id" = Hb."HitId"
    WHERE M."NormalizedName" LIKE 'a%'
    AND M."Type" = 4
    AND Hb."Id" IS NULL
),
"NewHits" AS (
    INSERT INTO "Hits" ("Start", "End", "MoveId", "Name")
    SELECT Hit."Start", Hit."End", AerialMove."Id", Hit."Name"
    FROM "MissingAerialHitboxes" Missing
    INNER JOIN "Moves" AerialMove ON Missing."Id" = AerialMove."Id"
    INNER JOIN "Moves" GroundedMove ON 'a' || GroundedMove."NormalizedName" = AerialMove."NormalizedName"
                                    AND GroundedMove."CharacterId" = AerialMove."CharacterId"
    INNER JOIN "Hits" Hit ON GroundedMove."Id" = Hit."MoveId"
    RETURNING "Id", "MoveId"
)
INSERT INTO "Hitboxes" (
    "Name", "Damage", "Angle", "KnockbackGrowth", "SetKnockback", "BaseKnockback",
    "Effect", "HitlagAttacker", "HitlagDefender", "Shieldstun", "HitlagAttackerCrouched",
    "HitlagDefenderCrouched", "YoshiArmorBreakPercentage", "IsWeightIndependent", "HitId"
)
SELECT
    Hitbox."Name", Hitbox."Damage", Hitbox."Angle", Hitbox."KnockbackGrowth", Hitbox."SetKnockback",
    Hitbox."BaseKnockback", Hitbox."Effect", Hitbox."HitlagAttacker", Hitbox."HitlagDefender",
    Hitbox."Shieldstun", Hitbox."HitlagAttackerCrouched", Hitbox."HitlagDefenderCrouched",
    Hitbox."YoshiArmorBreakPercentage", Hitbox."IsWeightIndependent", NewHits."Id"
FROM "NewHits"
INNER JOIN "Hits" CreatedHit ON CreatedHit."Id" = NewHits."Id"
INNER JOIN "Moves" AerialMove ON NewHits."MoveId" = AerialMove."Id"
INNER JOIN "Moves" GroundedMove ON 'a' || GroundedMove."NormalizedName" = AerialMove."NormalizedName"
                                AND GroundedMove."CharacterId" = AerialMove."CharacterId"
INNER JOIN "Hits" Hit ON GroundedMove."Id" = Hit."MoveId"
                      AND Hit."Name" = CreatedHit."Name"
INNER JOIN "Hitboxes" Hitbox ON Hit."Id" = Hitbox."HitId";
