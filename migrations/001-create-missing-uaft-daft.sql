-- Create the missing uafts
INSERT INTO Moves (Name, NormalizedName, TotalFrames, IASA, CharacterId, Type, [End], Start)
SELECT 'Forward Tilt (Up)' AS Name, 'uaft' as NormalizedName, M.TotalFrames, M.IASA, M.CharacterId, M.Type, M.[End], M.Start
FROM Moves M
INNER JOIN dbo.Characters C on M.CharacterId = C.Id
WHERE M.NormalizedName = 'ftilt'
AND C.NormalizedName IN ('falco', 'fox', 'iceclimbers', 'jigglypuff', 'kirby', 'zelda')

-- Create the missing dafts
INSERT INTO Moves (Name, NormalizedName, TotalFrames, IASA, CharacterId, Type, [End], Start)
SELECT 'Forward Tilt (Down)' AS Name, 'daft' as NormalizedName, M.TotalFrames, M.IASA, M.CharacterId, M.Type, M.[End], M.Start
FROM Moves M
INNER JOIN dbo.Characters C on M.CharacterId = C.Id
WHERE M.NormalizedName = 'ftilt'
AND C.NormalizedName IN ('falco', 'fox', 'iceclimbers', 'jigglypuff', 'kirby', 'zelda')
