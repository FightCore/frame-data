-- Update the moves for the TECH category
UPDATE Moves
SET Type = 7
FROM Moves
WHERE Type = 0
AND NormalizedName IN
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
)

-- Update the moves for the GRAB/THROW category
UPDATE Moves
SET Moves.Type = 6
WHERE Type = 0
AND NormalizedName IN ('grab', 'dashgrab', 'pummel')

-- Update the moves for the EDGE category
UPDATE Moves
SET Moves.Type = 8
WHERE Type = 0
AND NormalizedName IN ('edge')

-- Update kirby's special moves into its own category
UPDATE Moves
SET Moves.Type = 10
FROM Moves
INNER JOIN Characters
ON Moves.CharacterId = Characters.Id
WHERE Type = 0
AND Moves.NormalizedName LIKE '%special'
AND Characters.NormalizedName = 'kirby'

-- Update the item attacks to their own category
UPDATE Moves
SET Type = 9
FROM Moves
WHERE Type = 0
AND NormalizedName IN ('beamsword', 'mr_saturn')