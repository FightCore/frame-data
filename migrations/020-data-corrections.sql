-- Adjust Bowsers land lag to be 30/15f (Thank you Visser III)

UPDATE moves
SET landing_lag = 30,
l_canceled_land_lag = 15
WHERE id = 1212