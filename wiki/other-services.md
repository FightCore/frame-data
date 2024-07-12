# Other services

This document details the way that other services address data

## MeleeDatabase

MeleeDatabase (also known as MeleeFrameData) is the base of the FightCore database.
A lot data was taken from their database and thus a lot of terms might overlap.

MeleeDatabase is split up into 5 tables:

`attacks`, `dodges`, `grabs`, `misc`, `throws`

### Characters mapping

| FightCore Id | FightCore Normalized Name | MeleeDatabase       |
| ------------ | ------------------------- | ------------------- |
| 27           | captainfalcon             | captain_falcon      |
| 28           | roy                       | roy                 |
| 29           | pichu                     | pichu               |
| 30           | ness                      | ness                |
| 31           | mrgame&watch              | mr.\_game\_&\_watch |
| 32           | mewtwo                    | mewtwo              |
| 33           | link                      | link                |
| 34           | bowser                    | bowser              |
| 35           | kirby                     | kirby               |
| 36           | ganondorf                 | ganondorf           |
| 37           | donkeykong                | donkey_kong         |
| 38           | mario                     | mario               |
| 39           | drmario                   | dr._mario           |
| 40           | luigi                     | luigi               |
| 41           | yoshi                     | yoshi               |
| 42           | iceclimbers               | ice_climbers        |
| 43           | pikachu                   | pikachu             |
| 44           | peach                     | peach               |
| 45           | sheik                     | zelda               |
| 46           | samus                     | samus               |
| 47           | jigglypuff                | jigglypuff          |
| 48           | marth                     | marth               |
| 49           | fox                       | fox                 |
| 50           | falco                     | falco               |
| 51           | younglink                 | young_link          |
| 52           | zelda                     | zelda               |
| 53           | fwireframe                | -                   |

### Moves mapping

Details the normalized name of FightCore vs the MeleeDatabase.
Note that the empty values are just non-existant in the MeleeDatabase.
This is because FightCore has a lot of things like Kirby B abilities that MeleeDatabase
doesn't have.

| FightCore Normalized Name | MeleeDatabase Table | MeleeDatabase Name |
| ------------------------- | ------------------- | ------------------ |
| adownb                    | attacks             | adown_b            |
| airdodge                  | dodges              | air_dodge          |
| aneutralb                 | attacks             | aneutral_b         |
| asideb                    | attacks             | aside_b            |
| aupb                      | attacks             | aup_b              |
| bair                      | attacks             | bair               |
| beamsword                 |                     |                    |
| bgetup                    |                     |                    |
| bgetuprollback            |                     |                    |
| bgetuprollstomach         |                     |                    |
| bob_omb                   |                     |                    |
| bowserspecial             |                     |                    |
| btechroll                 |                     |                    |
| bthrow                    | throws              | back_throw         |
| captainfalconspecial      |                     |                    |
| cargo_bthrow              |                     |                    |
| cargo_dthrow              |                     |                    |
| cargo_fthrow              |                     |                    |
| cargo_uthrow              |                     |                    |
| daft                      |                     |                    |
| dair                      | attacks             | dair               |
| dashgrab                  | grabs               | dash_grab          |
| dattack                   | attacks             | dattack            |
| donkeykongspecial         |                     |                    |
| downb                     | attacks             | down_b             |
| drmariospecial            |                     |                    |
| dsmash                    | attacks             | dsmash             |
| dsmash_charge             |                     |                    |
| dthrow                    | throws              | down_throw         |
| dtilt                     | attacks             | dtilt              |
| edge                      |                     |                    |
| fair                      | attacks             | fair               |
| falcospecial              |                     |                    |
| fgetup                    |                     |                    |
| fgetuprollback            |                     |                    |
| fgetuprollstomach         |                     |                    |
| foxspecial                |                     |                    |
| fsmash                    | attacks             | fsmash             |
| fsmash2                   |                     |                    |
| ftechroll                 |                     |                    |
| fthrow                    | throws              | forward_throw      |
| ftilt                     | attacks             | ftilt              |
| ganondorfspecial          |                     |                    |
| grab                      | grabs               | standing_grab      |
| iceclimbersspecial        |                     |                    |
| jab1                      | attacks             | jab1               |
| jab2                      | attacks             | jab2               |
| jab3                      | attacks             | jab3               |
| jigglypuffspecial         |                     |                    |
| jump                      |                     |                    |
| linkspecial               |                     |                    |
| luigispecial              |                     |                    |
| mariospecial              |                     |                    |
| marthspecial              |                     |                    |
| mewtwospecial             |                     |                    |
| mr_saturn                 |                     |                    |
| mrgameandwatchspecial     |                     |                    |
| nair                      | attacks             | nair               |
| nessspecial               |                     |                    |
| neutralb                  | attacks             | neutral_b          |
| neutraltech               |                     |                    |
| peachspecial              |                     |                    |
| pichuspecial              |                     |                    |
| pikachuspecial            |                     |                    |
| pummel                    |                     |                    |
| rjab                      | attacks             | rjab               |
| rollbackwards             | dodges              | back_roll          |
| rollforward               | dodges              | forward_roll       |
| royspecial                |                     |                    |
| samusspecial              |                     |                    |
| sheikspecial              |                     |                    |
| sideb                     | attacks             | side_b             |
| sideb2                    |                     |                    |
| sideb2up                  |                     |                    |
| sideb3                    |                     |                    |
| sideb3down                |                     |                    |
| sideb3up                  |                     |                    |
| sideb4                    |                     |                    |
| sideb4down                |                     |                    |
| sideb4up                  |                     |                    |
| sidebmissfire             |                     |                    |
| spotdodge                 | dodges              | spot_dodge         |
| taunt                     |                     |                    |
| uaft                      |                     |                    |
| uair                      | attacks             | uair               |
| unknown                   |                     |                    |
| unknown_air               |                     |                    |
| upb                       | attacks             | up_b               |
| usmash                    | attacks             | usmash             |
| usmash_charge             |                     |                    |
| uthrow                    | throws              | up_throw           |
| utilt                     | attacks             | utilt              |
| walltech                  |                     |                    |
| walltechjump              |                     |                    |
| yoshispecial              |                     |                    |
| younglinkspecial          |                     |                    |
| zair                      |                     |                    |
| zeldaspecial              |                     |                    |
