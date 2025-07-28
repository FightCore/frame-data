UPDATE "Hits"
SET "MoveId" = "CorrectMoves"."Id"
FROM "Moves"
INNER JOIN "Moves" AS "CorrectMoves" ON "CorrectMoves"."CharacterId" = "Moves"."CharacterId"
AND "CorrectMoves"."NormalizedName" = 'a' || "Moves"."NormalizedName"
WHERE "Hits"."MoveId" = "Moves"."Id"
AND "Hits"."Name" LIKE 'air_%'
AND "Moves"."NormalizedName" NOT LIKE 'a%';
