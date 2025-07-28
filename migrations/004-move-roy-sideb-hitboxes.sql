WITH "ReplacementTable" ("NormalizedName", "id") AS (
    VALUES
        ('hit2_up', 1972),
        ('hit2_down', 1971),
        ('hit3_up_clean', 1974),
        ('hit3_up_late', 1974),
        ('hit3_side', 1973),
        ('hit3_down_hits1_3', 1976),
        ('hit3_down_hit4', 1976),
        ('hit4_up', 1978),
        ('hit4_side', 1977),
        ('hit4_down_hits1_4', 1979),
        ('hit4_down_hit5', 1979)
)
UPDATE "Hits"
SET "MoveId" = R."id"
FROM "Moves"
INNER JOIN "Characters" C ON "Moves"."CharacterId" = C."Id"
INNER JOIN "ReplacementTable" R ON R."NormalizedName" = "Hits"."Name"
WHERE "Hits"."MoveId" = "Moves"."Id"
  AND C."NormalizedName" = 'roy'
  AND ("Moves"."NormalizedName" LIKE 'sideb%' OR "Moves"."NormalizedName" = 'sideb');
