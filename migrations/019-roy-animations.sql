DROP TABLE IF EXISTS temp_moves;

CREATE TEMPORARY TABLE temp_moves (name TEXT);

INSERT INTO
    temp_moves (name)
VALUES ('pummel'),
    ('edge'),
    ('fgetup'),
    ('bgetup'),
    ('bgetuprollback'),
    ('bgetuprollstomach'),
    ('fgetuprollback'),
    ('fgetuprollstomach'),
    ('techneutral'),
    ('walltech'),
    ('walltechjump'),
    ('bthrow'),
    ('fthrow'),
    ('uthrow'),
    ('dthrow');

UPDATE "Moves" AS m
SET "GifUrl" = 'https://i.fightcore.gg/beta/roy/' || m."NormalizedName" || '.gif',
    "WebmUrl" =  'https://i.fightcore.gg/beta/roy/' || m."NormalizedName" || '.webm',
    "PngUrl" = 'https://i.fightcore.gg/png/roy/' || m."NormalizedName" || '.png'
FROM temp_moves
INNER JOIN "Characters"
ON "Characters"."NormalizedName" = 'roy'
WHERE m."CharacterId" = "Characters"."Id"
AND temp_moves.name = m."NormalizedName"

INSERT INTO
    "AlternativeAnimations" (
        "Description",
        "GifUrl",
        "WebmUrl",
        "PngUrl",
        "MoveId"
    )
VALUES (
        'Counter hit',
        'https://i.fightcore.gg/beta/roy/adownb_hit.gif',
        'https://i.fightcore.gg/beta/roy/adownb_hit.webm',
        'https://i.fightcore.gg/png/roy/adownb_hit.png',
        2012
    ),
    (
        'Counter hit',
        'https://i.fightcore.gg/beta/roy/downb_hit.gif',
        'https://i.fightcore.gg/beta/roy/downb_hit.webm',
        'https://i.fightcore.gg/png/roy/downb_hit.png',
        927
    ),
    (
        'Reverse',
        'https://i.fightcore.gg/beta/roy/upb_reverse.gif',
        'https://i.fightcore.gg/beta/roy/upb_reverse.webm',
        'https://i.fightcore.gg/png/roy/upb_reverse.png',
        946
    ),
    (
        'Full charge',
        'https://i.fightcore.gg/beta/roy/neutralb_full.gif',
        'https://i.fightcore.gg/beta/roy/neutralb_full.webm',
        'https://i.fightcore.gg/png/roy/neutralb_full.png',
        944
    );

INSERT INTO
    "Moves" (
        "Name",
        "NormalizedName",
        "LandLag",
        "LCanceledLandLag",
        "LandingFallSpecialLag",
        "TotalFrames",
        "IASA",
        "AutoCancelBefore",
        "AutoCancelAfter",
        "Start",
        "End",
        "Type",
        "Notes",
        "Percent",
        "CharacterId",
        "Source",
        "GifUrl",
        "WebmUrl",
        "PngUrl",
        "IsInterpolated"
    )
VALUES (
        'Edge Attack (Slow)',
        'edgeslow',
        null,
        null,
        null,
        0,
        null,
        null,
        null,
        null,
        null,
        8,
        null,
        null,
        28,
        null,
        'https://i.fightcore.gg/beta/roy/edgeslow.gif',
        'https://i.fightcore.gg/beta/roy/edgeslow.webm',
        'https://i.fightcore.gg/png/roy/edgeslow.png',
        false
    ),
    (
        'Edge Climb',
        'edgeclimb',
        null,
        null,
        null,
        0,
        null,
        null,
        null,
        null,
        null,
        8,
        null,
        null,
        28,
        null,
        'https://i.fightcore.gg/beta/roy/edgeclimb.gif',
        'https://i.fightcore.gg/beta/roy/edgeclimb.webm',
        'https://i.fightcore.gg/png/roy/edgeclimb.png',
        false
    ),
    (
        'Edge Climb (Slow)',
        'edgeclimbslow',
        null,
        null,
        null,
        0,
        null,
        null,
        null,
        null,
        null,
        8,
        null,
        null,
        28,
        null,
        'https://i.fightcore.gg/beta/roy/edgeclimbslow.gif',
        'https://i.fightcore.gg/beta/roy/edgeclimbslow.webm',
        'https://i.fightcore.gg/png/roy/edgeclimbslow.png',
        false
    ),
    (
        'Edge Roll Up',
        'edgeroll',
        null,
        null,
        null,
        0,
        null,
        null,
        null,
        null,
        null,
        8,
        null,
        null,
        28,
        null,
        'https://i.fightcore.gg/beta/roy/edgeroll.gif',
        'https://i.fightcore.gg/beta/roy/edgeroll.webm',
        'https://i.fightcore.gg/png/roy/edgeroll.png',
        false
    ),
    (
        'Edge Roll Up (Slow)',
        'edgerollslow',
        null,
        null,
        null,
        0,
        null,
        null,
        null,
        null,
        null,
        8,
        null,
        null,
        28,
        null,
        'https://i.fightcore.gg/beta/roy/edgerollslow.gif',
        'https://i.fightcore.gg/beta/roy/edgerollslow.webm',
        'https://i.fightcore.gg/png/roy/edgerollslow.png',
        false
    ),
    (
        'Edge Jump Up',
        'edgejump',
        null,
        null,
        null,
        0,
        null,
        null,
        null,
        null,
        null,
        8,
        null,
        null,
        28,
        null,
        'https://i.fightcore.gg/beta/roy/edgejump.gif',
        'https://i.fightcore.gg/beta/roy/edgejump.webm',
        'https://i.fightcore.gg/png/roy/edgejump.png',
        false
    ),
    (
        'Edge Jump Up (Slow)',
        'edgejumpslow',
        null,
        null,
        null,
        0,
        null,
        null,
        null,
        null,
        null,
        8,
        null,
        null,
        28,
        null,
        'https://i.fightcore.gg/beta/roy/edgejumpslow.gif',
        'https://i.fightcore.gg/beta/roy/edgejumpslow.webm',
        'https://i.fightcore.gg/png/roy/edgejumpslow.png',
        false
    )

-- Add appropriate sources
INSERT INTO
    "MoveSource" ("MovesId", "SourcesId")
VALUES (1, 6),
    (2, 6),
    (3, 6),
    (4, 6),
    (5, 6),
    (6, 6),
    (7, 6)

DROP TABLE IF EXISTS temp_moves;

CREATE TEMPORARY TABLE temp_moves (name TEXT);

INSERT INTO
    temp_moves (name)
VALUES ('pummel'),
    ('edge'),
    ('fgetup'),
    ('bgetup'),
    ('bgetuprollback'),
    ('bgetuprollstomach'),
    ('fgetuprollback'),
    ('fgetuprollstomach'),
    ('techneutral'),
    ('walltech'),
    ('walltechjump'),
    ('bthrow'),
    ('fthrow'),
    ('uthrow'),
    ('dthrow');

INSERT INTO "MoveSource"
select m."Id" as MoveId, 6 as SourceId
FROM "Moves" m
INNER JOIN temp_moves
ON temp_moves.name = m."NormalizedName"
INNER JOIN "Characters"
ON "Characters"."NormalizedName" = 'roy'
WHERE m."CharacterId" = "Characters"."Id"

INSERT INTO "MoveSource" VALUES (2012, 6), (927, 6), (946, 6), (944, 6)