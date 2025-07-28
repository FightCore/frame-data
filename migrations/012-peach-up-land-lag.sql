UPDATE "Moves"
SET "Notes" = 'Frame data refers to peach rising, 11 hits total (no info on %s). can fast fall as soon as frame 56. Land lag with parasol closed is 4 frames.'
FROM "Characters"
WHERE "Moves"."CharacterId" = "Characters"."Id"
AND "Characters"."NormalizedName" = 'peach'
AND "Moves"."NormalizedName" = 'upb';
