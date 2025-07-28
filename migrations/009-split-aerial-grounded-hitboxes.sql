DELETE FROM "Hitboxes"
WHERE "Id" IN (
    SELECT hb."Id"
    FROM "Hitboxes" hb
    INNER JOIN "Hits" H on H."Id" = hb."HitId"
    INNER JOIN "Moves" M on H."MoveId" = M."Id"
    WHERE M."NormalizedName" NOT LIKE 'a%'
    AND M."NormalizedName" LIKE '%b'
    AND (H."Name" LIKE '%air%' OR H."Name" = 'air')
);

DELETE FROM "Hits"
WHERE "Id" IN (
    SELECT H."Id"
    FROM "Hits" H
    INNER JOIN "Moves" M on H."MoveId" = M."Id"
    WHERE M."NormalizedName" NOT LIKE 'a%'
    AND M."NormalizedName" LIKE '%b'
    AND (H."Name" LIKE '%air%' OR H."Name" = 'air')
);

-- Remove any hitbox from the aerial moves that are labelled as "ground"
DELETE FROM "Hitboxes"
WHERE "Id" IN (
    SELECT hb."Id"
    FROM "Hitboxes" hb
    INNER JOIN "Hits" H on H."Id" = hb."HitId"
    INNER JOIN "Moves" M on H."MoveId" = M."Id"
    WHERE M."NormalizedName" LIKE 'a%'
    AND (H."Name" LIKE '%ground%' OR H."Name" = 'ground')
);

DELETE FROM "Hits"
WHERE "Id" IN (
    SELECT H."Id"
    FROM "Hits" H
    INNER JOIN "Moves" M on H."MoveId" = M."Id"
    WHERE M."NormalizedName" LIKE 'a%'
    AND (H."Name" LIKE '%ground%' OR H."Name" = 'ground')
);
