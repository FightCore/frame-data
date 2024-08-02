DELETE Hitboxes
FROM Hitboxes
INNER JOIN dbo.Hits H on H.Id = Hitboxes.HitId
INNER JOIN dbo.Moves M on H.MoveId = M.Id
WHERE M.NormalizedName NOT LIKE 'a%'
AND M.NormalizedName LIKE '%b'
AND (H.Name LIKE '%air%' OR H.Name = 'air')

DELETE H
FROM Hits H
INNER JOIN dbo.Moves M on H.MoveId = M.Id
WHERE M.NormalizedName NOT LIKE 'a%'
AND M.NormalizedName LIKE '%b'
AND (H.Name LIKE '%air%' OR H.Name = 'air')


-- Remove any hitbox from the aerial moves that are labelled as "ground"
DELETE Hitboxes
FROM Hitboxes
INNER JOIN dbo.Hits H on H.Id = Hitboxes.HitId
INNER JOIN dbo.Moves M on H.MoveId = M.Id
WHERE M.NormalizedName LIKE 'a%'
AND (H.Name LIKE '%ground%' OR H.Name = 'ground')

DELETE H
FROM dbo.Hits H
INNER JOIN dbo.Moves M on H.MoveId = M.Id
WHERE M.NormalizedName LIKE 'a%'
AND (H.Name LIKE '%ground%' OR H.Name = 'ground')