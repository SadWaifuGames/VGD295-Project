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

Updated New Level Requirements 3/26/20

Main Camera

Background Object:

	-Sprite Renderer
	
	-Random Background Script
	
	-Audio Source (play on awake checked and volume at  0.4)
	
	-Random End Game Sounds Script
	
Fish Empty Object to contain the fish prefabs

	Fish need:
		-Sprite renderer (Order in Layer = 3)
		-Rigid 2D Body
		-Drag and Drop Script or some kind of movement script (mad sprite, selection effect, and death effect, audio clip array)
		-Random Patrol Script (min X = -8.4, max X = 3.4, min Y = -4.8, max Y = 4.8, speed, max speed and seconds to difficulty are variable)
		-Capsule Collider 2D (is trigger checked)
		-Audio Source (uncheck play on awake, volume at 0.36)
		
Canvas/Event System

	-Death Screen prefab (Has Restart, Menu, Fish Fact and Nice Try text)
	-Restart, Menu need Onclick events from the Level Manager
	-Score Prefab
	-Win Text Prefab
	
Player Prefab with Appropriate items dragged into the script in the inspector

Trophy prefab (fish from the level dragged into the inspector on the trophy script)

Level Manager prefab
