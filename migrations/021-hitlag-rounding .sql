CREATE OR REPLACE FUNCTION calculate_hitlag(hitbox_id bigint, is_defender boolean, is_crouched boolean)
RETURNS INTEGER AS $$
DECLARE
    hitlag NUMERIC;
    hitbox_damage NUMERIC;
    hitbox_effect VARCHAR;
BEGIN
    SELECT damage, effect INTO hitbox_damage, hitbox_effect FROM hitboxes WHERE id = hitbox_id;

    IF (hitbox_damage = 0) THEN
        RETURN 0;
    END IF;

    hitlag := TRUNC(hitbox_damage / 3.0 + 3.0);

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
UPDATE hitboxes
SET "hitlag_attacker" = calculate_hitlag("id", false, false),
    "hitlag_attacker_crouched" = calculate_hitlag("id", false, false),
    "hitlag_defender" = calculate_hitlag("id", true, false),
    "hitlag_defender_crouched" = calculate_hitlag("id", true, true)
