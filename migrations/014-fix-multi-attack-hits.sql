-- Remove hit from bowser's down air that does not exist
DELETE Hitboxes
WHERE HitId = 2140
DELETE Hits
WHERE Id = 2140

-- Update the move to have the correct [End] frame
UPDATE Moves
SET [End] = 39
WHERE Id = 1216

-- Fix the bowser down smash's strong hit
DELETE Hitboxes
WHERE HitId = 2127
DELETE Hits
WHERE Id = 2127

UPDATE Hits
SET [Start] = 32,
    [End] = 32
WHERE Id = 2128

UPDATE Moves
SET [End] = 32
WHERE Id = 1211

-- Fix Captain Falcon's up air having an impossible hitbox
DELETE Hitboxes
WHERE HitId = 2179
DELETE Hits
WHERE Id = 2179

UPDATE Moves
SET [End] = 13
WHERE Id = 1105

-- Move ending hit from Ice Climbers from frame 29 to frame 26
DELETE Hitboxes
WHERE HitId = 2334
DELETE Hits
WHERE ID = 2334

UPDATE Hits
SET [Start] = 26, [End] = 26
WHERE ID = 2335

-- Fix Jigglypuff's down air incorrect last hitbox
DELETE Hitboxes
WHERE HitId = 2378
DELETE Hits
WHERE Id = 2378

UPDATE Moves
SET [End] = 27
WHERE id = 963

-- Remove Kirby's down air incorrect last hitbox
-- Remove the incorrect note from the move
DELETE Hitboxes
WHERE HitId = 2419
DELETE Hits
WHERE Id = 2419

UPDATE Moves
SET [End] = 34,
    Notes = NULL
WHERE Id = 1174


-- Add a note to kirby's dash attack due to an in-game bug
UPDATE Moves
SET Notes = 'IASA frame is not visualized within animation due to a bug in the game.'
WHERE Id = 1163

-- Fix Captain Falcon's third jab starting on frame 0 instead of 1.
UPDATE Hits
SET [Start] = 6, [End] = 9
WHERE Id = 2162

UPDATE Hits
SET [Start] = 10, [End] = 12
WHERE Id = 2163

-- Remove a bad mario down air hitbox
-- Fix the auto cancel after
DELETE Hitboxes
WHERE HitId = 2513
DELETE Hits
WHERE Id = 2513

UPDATE Moves
SET [End] = 29,
    AutoCancelAfter = 32
WHERE Id = 845

-- Fix mewtwo having an extra neutral air hitbox and incorrect IASA and autocancel after.
DELETE Hitboxes
WHERE HitId = 2571
DELETE Hits
WHERE Id = 2571

UPDATE Hits
SET [Start] = 37, [End] = 38
WHERE Id = 2572

UPDATE Moves
SET IASA = 42,
    AutoCancelAfter = 36
WHERE Id = 1033

-- Update mewtwo rapid jabs to correct for a 0'th frame
UPDATE Hits
SET [Start] = 6, [End] = 6
WHERE Id = 2544

UPDATE Hits
SET [Start] = 13, [End] = 13
WHERE Id = 2545

UPDATE Hits
SET [Start] = 20, [End] = 20
WHERE Id = 2546

UPDATE Hits
SET [Start] = 27, [End] = 27
WHERE Id = 2547

UPDATE Hits
SET [Start] = 34, [End] = 34
WHERE Id = 2548

UPDATE Hits
SET [Start] = 41, [End] = 41
WHERE Id = 2549

UPDATE Hits
SET [Start] = 48, [End] = 48
WHERE Id = 2550

UPDATE Moves
SET [End] = 48,
    Notes = 'After last hitbox there is an additional 13 frame cooldown'
WHERE Id = 1511

-- Fix mewtwo's upsmash timing being wrong
DELETE Hitboxes
WHERE HitId = 2560
DELETE Hits
WHERE Id = 2560

UPDATE Hits
SET [Start] = 33, [End] = 34
WHERE Id = 2561

UPDATE Moves
SET [End] = 34
WHERE Id = 1258

-- Add a note that the IASA frame is not visualized in the game
UPDATE Moves
SET Notes = 'IASA frame is not visualized within animation due to a bug in the game.'
WHERE Id = 731

-- Fix the loop of hitboxes being incorrect on Ness forward air
DELETE Hitboxes
WHERE HitId = 2622
DELETE Hits
WHERE Id = 2622

UPDATE Hits
SET [Start] = 20, [End] = 21
WHERE Id = 2623

UPDATE Moves
SET [End] = 21
WHERE Id = 733

-- Fix ness' jab3 starting on frame 0 instead of 1
UPDATE Hits
SET [Start] = 6, [End] = 7
WHERE Id = 2606

UPDATE Hits
SET [Start] = 8, [End] = 9
WHERE Id = 2607

UPDATE Moves
SET [End] = 9
WHERE Id = 1514

-- Fix Peach dair having the wrong number of hits
-- Set IASA frame to the proper value
DELETE Hitboxes
WHERE HitId = 2659
DELETE Hits
WHERE Id = 2659

UPDATE Moves
SET [End] = 31,
    IASA = 36
WHERE Id = 765

-- Remove wrong loop hitbox for Pichu's forward air
DELETE Hitboxes
WHERE HitId = 2688
DELETE Hits
WHERE Id = 2688

UPDATE Moves
SET [End] = 24,
AutoCancelAfter = 33
WHERE Id = 743

-- Fix Pichu's forward smash having too long of a normal hits
DELETE Hitboxes
WHERE HitId = 2678
DELETE Hits
WHERE Id = 2678

UPDATE Hits
SET [Start] = 31, [End] = 33
WHERE Id = 2679

UPDATE Moves
SET [End] = 33
WHERE Id = 757

-- Fix Pikachu's down smash having one loop hitbox too many
DELETE Hitboxes
WHERE HitId = 2722
DELETE Hits
WHERE Id = 2722

UPDATE Hits
SET [Start] = 25, [End] = 25
WHERE Id = 2723

UPDATE Moves
SET [End] = 25
WHERE Id = 975

-- Fix Pikachu's forward air having the wrong loop hitboxs
DELETE Hitboxes
WHERE HitId = 2730
DELETE Hits
WHERE Id = 2730

UPDATE Moves
SET [End] = 24,
AutoCancelAfter = 33
WHERE Id = 977

UPDATE Moves
SET Notes = NULL
WHERE Id = 979

-- Fix Roy's second hit of dsmash being noted as one frame too late
UPDATE Hits
SET [Start] = 23, [End] = 25
WHERE Id = 2761

UPDATE Moves
SET [End] = 25,
Notes = NULL
WHERE Id = 914

-- Fix Roy's up smash having a hitbox that doesn't exist
DELETE Hitboxes
WHERE HitId = 2758
DELETE Hits
WHERE Id = 2758

UPDATE Hits
SET [Start] = 23, [End] = 24
WHERE Id = 2759

UPDATE Moves
SET [End] = 24
WHERE Id = 913

-- Fix Samus' dashgrab starting a frame later
UPDATE Hits
SET [Start] = 18, [End] = 20
WHERE Id = 2809

UPDATE Hits
SET [Start] = 21, [End] = 22
WHERE Id = 2810

UPDATE Hits
SET [Start] = 32, [End] = 33
WHERE Id = 2814

UPDATE Moves
SET [Start] = 18, [End] = 33,
Notes = 'First hitbox is a hand grab which last 3 frames, after that the grapple is used.'
WHERE Id = 1610

-- Fix Samus' forward air hits are all on the wrong frames
UPDATE Hits
SET [Start] = 4, [End] = 5
WHERE Id = 2787

UPDATE Hits
SET [Start] = 11, [End] = 12
WHERE Id = 2788

UPDATE Hits
SET [Start] = 18, [End] = 19
WHERE Id = 2789

UPDATE Hits
SET [Start] = 25, [End] = 26
WHERE Id = 2790

UPDATE Hits
SET [Start] = 30, [End] = 31
WHERE Id = 2792

DELETE Hitboxes
WHERE HitId = 2791
DELETE Hits
WHERE Id = 2791

-- Samus up air fixes, wrong due to loop
UPDATE Hits
SET [Start] = 20, [End] = 21
WHERE Id = 2800

DELETE Hitboxes
WHERE HitId = 2799
DELETE Hits
WHERE Id = 2799

UPDATE Moves
SET [End] = 21
WHERE Id = 1029
-- Sheik rapid jab fixes due to 0 frame
UPDATE Hits
SET [Start] = 3, [End] = 4
WHERE Id = 2831

UPDATE Hits
SET [Start] = 9, [End] = 10
WHERE Id = 2832

UPDATE Hits
SET [Start] = 15, [End] = 16
WHERE Id = 2833

UPDATE Hits
SET [Start] = 21, [End] = 22
WHERE Id = 2834

UPDATE Hits
SET [Start] = 27, [End] = 28
WHERE Id = 2835

UPDATE Hits
SET [Start] = 33, [End] = 34
WHERE Id = 2836

UPDATE Moves
SET [Start] = 3, [End] = 34,
    Notes = 'Loop has an additional 6 frames startup and 8 frames endlag'
WHERE Id = 1611

-- Fix Yoshi's down air having a hitbox that does not exist
DELETE Hitboxes
WHERE HitId = 2887
DELETE Hits
WHERE Id = 2887

UPDATE Moves
SET [End] = 44,
    Notes = NULL,
    AutoCancelAfter = 49,
    IASA = 53
WHERE Id = 905

-- Fix Yoshi's grab having a 0th frame
DELETE Hitboxes
WHERE HitId = 2889
DELETE Hits
WHERE Id = 2889

UPDATE Hits
SET [End] = 23
WHERE Id = 2890

-- Fix Young Link dash grab having wrong timings
UPDATE Hits
SET [Start] = 14, [End] = 15
WHERE Id = 2920

UPDATE Hits
SET [Start] = 14, [End] = 17
WHERE Id = 2921

-- Fix Young Link grab having wrong timings
UPDATE Hits
SET [Start] = 11, [End] = 13
WHERE Id = 2918

UPDATE Hits
SET [Start] = 11, [End] = 14
WHERE Id = 2919

-- Fix Zelda's forward smash having bad timings due to loops
DELETE Hitboxes
WHERE HitId = 2940
DELETE Hits
WHERE Id = 2940

UPDATE Hits
SET [Start] = 24, [End] = 24
WHERE Id = 2941

UPDATE Moves
SET [End] = 24
WHERE Id = 1146

-- Fix Zelda's jab having bad timings due to loops
DELETE Hitboxes
WHERE HitId = 2933
DELETE Hits
WHERE Id = 2933

UPDATE Moves
SET [End] = 15, Notes = NULL
WHERE Id = 1531

-- Fix Zelda's nair having bad timings due to loops
DELETE Hitboxes
WHERE HitId = 2963
DELETE Hits
WHERE Id = 2963

UPDATE Hits
SET [Start] = 26, [End] = 27
WHERE Id = 2964

UPDATE Moves
SET [End] = 27
WHERE Id = 1147

-- Fix Zelda's up smash having bad timings due to loops
DELETE Hitboxes
WHERE HitId = 2954
DELETE Hits
WHERE Id = 2954

UPDATE Hits
SET [Start] = 34, [End] = 34
WHERE Id = 2955

UPDATE Moves
SET [End] = 34
WHERE Id = 1147

-- Fix Links grab having a 0th frame
UPDATE Hits
SET [Start] = 11, [End] = 13
WHERE Id = 2456

UPDATE Hits
SET [Start] = 11, [End] = 17
WHERE Id = 2457

UPDATE Moves
SET [End] = 17,
Notes = 'First hitbox is a hand grab which is frame 11-13, grapple is from 11-17'
WHERE Id = 1591

-- Fix Link's dash grab having a 0th frame
UPDATE Hits
SET [Start] = 12, [End] = 12
WHERE Id = 2458

UPDATE Hits
SET [Start] = 12, [End] = 17
WHERE Id = 2459

-- Fix Samus' grab having a 0th frame
UPDATE Hits
SET [Start] = 18, [End] = 19
WHERE Id = 2801

DELETE Hitboxes
WHERE HitId = 2808
DELETE Hits
WHERE Id = 2808