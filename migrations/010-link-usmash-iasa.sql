UPDATE "Moves"
SET "IASA" = 52
FROM "Characters" C
WHERE "Moves"."CharacterId" = C."Id"
AND C."NormalizedName" = 'link'
AND "Moves"."NormalizedName" = 'usmash';
