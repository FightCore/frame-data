-- Fix Sheik's grab saying its frame 6-7 instead of f7-8 (its correct in the hitboxes)
UPDATE moves
SET [start] = 7,
[end] = 8
WHERE id = 1611