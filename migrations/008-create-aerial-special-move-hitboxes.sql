DROP TABLE IF EXISTS #MissingAerialHitboxes

CREATE TABLE #MissingAerialHitboxes(id bigint)
INSERT INTO #MissingAerialHitboxes
SELECT M.Id
FROM Moves M
LEFT JOIN dbo.Hits H on M.Id = H.MoveId
LEFT JOIN dbo.Hitboxes Hb ON H.Id = Hb.HitId
WHERE M.NormalizedName LIKE 'a%'
AND M.Type = 4
AND Hb.Id IS NULL

CREATE TABLE #CreateHits (id bigint, moveId bigint)

INSERT INTO Hits (Start, [End], MoveId, Name)
OUTPUT inserted.Id, inserted.MoveId INTO #CreateHits (id, moveId)
SELECT Hit.Start, Hit.[End], AerialMove.Id, Hit.Name
FROM #MissingAerialHitboxes Missing
INNER JOIN Moves AerialMove
ON Missing.Id = AerialMove.Id
INNER JOIN Moves GroundedMove
ON 'a' + GroundedMove.NormalizedName = AerialMove.NormalizedName
AND GroundedMove.CharacterId = AerialMove.CharacterId
INNER JOIN Hits Hit
ON GroundedMove.Id = Hit.MoveId

INSERT INTO Hitboxes (Name, Damage, Angle, KnockbackGrowth, SetKnockback, BaseKnockback, Effect, HitlagAttacker, HitlagDefender, Shieldstun, HitlagAttackerCrouched, HitlagDefenderCrouched, YoshiArmorBreakPercentage, IsWeightIndependent, HitId)
SELECT Hitbox.Name, Hitbox.Damage, Hitbox.Angle, Hitbox.KnockbackGrowth, Hitbox.SetKnockback, Hitbox.BaseKnockback, Hitbox.Effect, Hitbox.HitlagAttacker, Hitbox.HitlagDefender, Hitbox.Shieldstun, Hitbox.HitlagAttackerCrouched, Hitbox.HitlagDefenderCrouched, Hitbox.YoshiArmorBreakPercentage, Hitbox.IsWeightIndependent, #CreateHits.Id
FROM #CreateHits
INNER JOIN Hits CreatedHit
ON CreatedHit.ID = #createHits.Id
INNER JOIN Moves AerialMove
ON #CreateHits.moveId = AerialMove.Id
INNER JOIN Moves GroundedMove
ON 'a' + GroundedMove.NormalizedName = AerialMove.NormalizedName
AND GroundedMove.CharacterId = AerialMove.CharacterId
INNER JOIN Hits Hit
ON GroundedMove.Id = Hit.MoveId
AND Hit.Name = CreatedHit.Name
INNER JOIN Hitboxes Hitbox
ON Hit.Id = Hitbox.HitId