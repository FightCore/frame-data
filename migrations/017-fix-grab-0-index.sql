WITH FirstHit AS (
    SELECT "MoveId", MIN("Start") AS Start, MIN("End") as "End", MIN("Id") HitId
    FROM "Hits"
    WHERE "Start" > 0
    GROUP BY "MoveId"
),

CorrectedHit AS (
    SELECT FirstHit.HitId, "Moves"."Start", "Moves"."End"
    FROM "Moves"
    INNER JOIN FirstHit
    ON FirstHit."MoveId" = "Moves"."Id"
    WHERE "Moves"."Start" != FirstHit.Start
    AND "Moves"."Name" IN ('Grab', 'Dashgrab')
)

UPDATE "Hits"
SET "Start" = CorrectedHit."Start",
    "End" = CorrectedHit."End"
FROM CorrectedHit
WHERE CorrectedHit.HitId = "Hits"."Id"