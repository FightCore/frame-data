UPDATE Hits
SET Hits.MoveId = CorrectMoves.Id
FROM Hits
INNER JOIN Moves ON Hits.MoveId = Moves.Id
INNER JOIN Moves AS  CorrectMoves
ON CorrectMoves.CharacterId = Moves.CharacterId
AND CorrectMoves.NormalizedName = 'a' + Moves.NormalizedName
WHERE Hits.Name LIKE 'air_%'
AND Moves.NormalizedName NOT LIKE 'a%'