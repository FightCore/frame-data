UPDATE Moves
SET IASA = 52
FROM Moves
INNER JOIN dbo.Characters C on Moves.CharacterId = C.Id
WHERE C.NormalizedName = 'link'
AND Moves.NormalizedName = 'usmash'