-- Fix Falcon's frame data being incorrect
UPDATE "Moves"
SET "Start" = 6,
    "End" = 12,
    "IASA" = 23
WHERE "Id" = 1480

-- Fix Mewtwos start frame being incorrect
UPDATE "Moves"
SET "Start" = 6
WHERE "Id" = 1511

-- Young Link jab 2 incorrect hit frames
UPDATE "Hits"
SET "Start" = 7,
    "End" = 8
WHERE "Id" = 2899

-- Young Link jab 3 incorrect hit frames
UPDATE "Hits"
SET "Start" = 7,
    "End" = 11
WHERE "Id" = 2900;

UPDATE "Moves"
SET "End" = 11
WHERE "Id" = 1529;

-- Ice Climbers Jab 2
UPDATE "Hits"
SET "Start" = 5,
    "End" = 7
WHERE "Id" = 2901;

UPDATE "Moves"
SET "IASA" = 19
WHERE "Id" = 1535;