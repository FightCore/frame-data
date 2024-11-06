UPDATE Moves
SET Start = 7,
[End] = 8,
IASA = 18,
TotalFrames = 22
FROM Moves
INNER JOIN Characters ON Moves.CharacterId = Characters.Id
WHERE Characters.NormalizedName = 'younglink'
AND Moves.NormalizedName = 'jab2'

UPDATE Moves
SET Start = 7,
[End] = 10,
IASA = 33,
TotalFrames = 50
FROM Moves
INNER JOIN Characters ON Moves.CharacterId = Characters.Id
WHERE Characters.NormalizedName = 'younglink'
AND Moves.NormalizedName = 'jab3'

UPDATE Moves
SET Start = 7,
[End] = 12,
IASA = 40,
TotalFrames = 53
FROM Moves
INNER JOIN Characters ON Moves.CharacterId = Characters.Id
WHERE Characters.NormalizedName = 'younglink'
AND Moves.NormalizedName = 'dattack'

UPDATE Moves
SET Start = 11,
[End] = 15,
LandLag = 30
FROM Moves
INNER JOIN Characters ON Moves.CharacterId = Characters.Id
WHERE Characters.NormalizedName = 'younglink'
AND Moves.NormalizedName = 'zair'

UPDATE Moves
SET Start = 3,
[End] = 32,
TotalFrames = 35,
Notes = 'Separate 7 frame startup animation'
FROM Moves
INNER JOIN Characters ON Moves.CharacterId = Characters.Id
WHERE Characters.NormalizedName = 'younglink'
AND Moves.NormalizedName = 'rjab'

UPDATE Moves
SET Start = 14,
[End] = 46,
Notes = 'Arrow lasts 55 frames minimum (if it does not hit ground), 13 frames startup and 25 frames endlag upon release'
FROM Moves
INNER JOIN Characters ON Moves.CharacterId = Characters.Id
WHERE Characters.NormalizedName = 'younglink'
AND Moves.NormalizedName = 'neutralb'

UPDATE Moves
SET Start = 27,
[End] = 167
FROM Moves
INNER JOIN Characters ON Moves.CharacterId = Characters.Id
WHERE Characters.NormalizedName = 'younglink'
AND Moves.NormalizedName = 'sideb'

UPDATE Moves
SET Start = 27,
[End] = 167
FROM Moves
INNER JOIN Characters ON Moves.CharacterId = Characters.Id
WHERE Characters.NormalizedName = 'younglink'
AND Moves.NormalizedName = 'asideb'

UPDATE Moves
SET Start = 8,
[End] = 44,
TotalFrames = 79,
Notes = 'Hits 8-43 loop for 1% damage, final hit on frame 44 for 3% damage'
FROM Moves
INNER JOIN Characters ON Moves.CharacterId = Characters.Id
WHERE Characters.NormalizedName = 'younglink'
AND Moves.NormalizedName = 'upb'

UPDATE Moves
SET Start = 4,
[End] = 29
FROM Moves
INNER JOIN Characters ON Moves.CharacterId = Characters.Id
WHERE Characters.NormalizedName = 'younglink'
AND Moves.NormalizedName = 'airdodge'