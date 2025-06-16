-- Update Peach's down smash ending on a hitbox that does not exist.
-- Was previously 26.
UPDATE Moves
SET [End] = 22
FROM Moves
WHERE Id = 739
