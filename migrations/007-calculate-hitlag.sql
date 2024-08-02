CREATE FUNCTION CalculateHitlag(@hitboxId int, @isDefender bit, @isCrouched bit)
			RETURNS INT
			WITH EXECUTE AS CALLER
			AS
			BEGIN
				DECLARE @Hitlag DECIMAL;
				IF ((SELECT H.Damage FROM [Hitboxes] H WHERE H.Id = @hitboxId) = 0)
					RETURN 0;

				SET @Hitlag = (SELECT ROUND(CAST(H.Damage AS DECIMAL) / 3.0 + 3.0, 0)
					FROM [Hitboxes] H
					WHERE H.Id = @hitboxId);

                IF ((SELECT H.Effect FROM [Hitboxes] H WHERE H.Id = @hitboxId) = 'Electric' AND @isDefender = 1)
                    SET @Hitlag = ROUND(@Hitlag * 1.5, 0)

                IF (@isCrouched = 1)
                    SET @Hitlag = ROUND(@Hitlag * 0.666667, 0)

                IF (@Hitlag >= 20)
                    RETURN 20;

                RETURN @Hitlag;
			END
GO

UPDATE Hitboxes
    SET HitlagAttacker = dbo.CalculateHitlag(Hitboxes.Id, 0, 0),
    HitlagAttackerCrouched = dbo.CalculateHitlag(Hitboxes.Id, 0, 1),
    HitlagDefender = dbo.CalculateHitlag(Hitboxes.Id, 1, 0),
    HitlagDefenderCrouched = dbo.CalculateHitlag(Hitboxes.Id, 1, 1)
FROM Hitboxes
