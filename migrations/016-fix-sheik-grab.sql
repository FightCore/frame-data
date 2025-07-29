-- Set Sheik's grab to have the correct frame data and note.
UPDATE "Moves" SET "Start" = 3, "End" = 34, "Notes" = 'Loop has an additional 6 frames startup and 8 frames endlag' WHERE "Id" = 1524;

UPDATE "Moves" SET "Start" = 6, "End" = 7, "Notes" = NULL WHERE "Id" = 1611;