# VGD295-Project
Unity Game called Fish Sticks by Lexi Lewis and Rebekah Walls
last updated 2/26 by Lexi Lewis

A few notes on Fish

For a "normal fish" the following should be attached:
1. Sprite Render
2. Rigidbody 2d
3. Drag and Drop Script (attach audio clips and prefabs for sprites and effects)
4. Random Patrol script (values are -8.37, 3.56,-4.78, 4.79, 2, 5, 60)
5. Capsule Collider 2d
6. Audio source (uncheck play on awake and loop, volume at about .4)

For a Growing fish
replace drag and drop script with the grow fish script

For a Speedy fish
replace Random Patrol Script with the SpeedyRandomPatrol Script
replace Drag and Drop with SpeedFish Script

A few notes on creating New Levels
New Levels need the following...
1. Main Camera
2. Background Object with a sprite renderer, random background script, and Audio Source (check the box for play on awake, volume about .4)
3. Random End Game Sounds script, fill this with the music files from the music folder in audio
4. Canvas
5. Death Screen Prefab
6. Score Prefab
7. One, Two and Three star prefabs
8. Game Manager Prefab
9. Level Manager Prefab (controls button events)
Fish Objects need the following...
1. See Fish notes above!!
