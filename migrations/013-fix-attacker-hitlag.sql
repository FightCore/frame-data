CREATE OR REPLACE FUNCTION calculate_hitlag(hitbox_id integer, is_defender boolean, is_crouched boolean)
RETURNS INTEGER AS $$
DECLARE
    hitlag NUMERIC;
    hitbox_damage NUMERIC;
    hitbox_effect VARCHAR;
BEGIN
    SELECT "Damage", "Effect" INTO hitbox_damage, hitbox_effect FROM "Hitboxes" WHERE "Id" = hitbox_id;

    IF (hitbox_damage = 0) THEN
        RETURN 0;
    END IF;

    hitlag := ROUND(hitbox_damage / 3.0 + 3.0);

    IF (hitbox_effect = 'Electric' AND is_defender) THEN
        hitlag := TRUNC(hitlag * 1.5);
    END IF;

    IF (is_crouched) THEN
        hitlag := TRUNC(hitlag * 0.666667);
    END IF;

    IF (hitlag >= 20) THEN
        RETURN 20;
    END IF;

    RETURN hitlag;
END;
$$ LANGUAGE plpgsql;

UPDATE "Hitboxes"
SET "HitlagAttacker" = calculate_hitlag("Id", false, false),
    "HitlagDefender" = calculate_hitlag("Id", true, false),
    "HitlagDefenderCrouched" = calculate_hitlag("Id", true, true);