WITH "ReplacementTable" ("NormalizedName", "id") AS (
    VALUES
        ('hit2_up', 1983),
        ('hit2_down', 1982),
        ('hit3_up', 1985),
        ('hit3_side', 1984),
        ('hit3_down', 1986),
        ('hit4_up', 1989),
        ('hit4_side', 1988),
        ('hit4_down_1_4', 1990),
        ('hit4_down_5', 1990)
)
UPDATE "Hits"
SET "MoveId" = R."id"
FROM "Moves"
INNER JOIN "Characters" C ON "Moves"."CharacterId" = C."Id"
INNER JOIN "ReplacementTable" R ON R."NormalizedName" = "Hits"."Name"
WHERE "Hits"."MoveId" = "Moves"."Id"
  AND C."NormalizedName" = 'marth'
  AND ("Moves"."NormalizedName" LIKE 'sideb%' OR "Moves"."NormalizedName" = 'sideb');
