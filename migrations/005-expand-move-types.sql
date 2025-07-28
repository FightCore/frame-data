-- Update the moves for the TECH category
UPDATE "Moves"
SET "Type" = 7
WHERE "Type" = 0
AND "NormalizedName" IN
(
'bgetup',
'bgetuprollback',
'bgetuprollstomach',
'btechroll',
'fgetup',
'fgetuprollback',
'fgetuprollstomach',
'ftechroll',
'walltech',
'walltechjump',
'neutraltech'
);

-- Update the moves for the GRAB/THROW category
UPDATE "Moves"
SET "Type" = 6
WHERE "Type" = 0
AND "NormalizedName" IN ('grab', 'dashgrab', 'pummel');

-- Update the moves for the EDGE category
UPDATE "Moves"
SET "Type" = 8
WHERE "Type" = 0
AND "NormalizedName" IN ('edge');

-- Update kirby's special moves into its own category
UPDATE "Moves"
SET "Type" = 10
FROM "Characters"
WHERE "Moves"."CharacterId" = "Characters"."Id"
AND "Moves"."Type" = 0
AND "Moves"."NormalizedName" LIKE '%special'
AND "Characters"."NormalizedName" = 'kirby';

-- Update the item attacks to their own category
UPDATE "Moves"
SET "Type" = 9
WHERE "Type" = 0
AND "NormalizedName" IN ('beamsword', 'mr_saturn');
