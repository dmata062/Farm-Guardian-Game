
**IT 201 \- “Farm Guardian” (Original Design) 1 \- Game Introduction:** 

For my final project, I have decided to create a farming defense game. You are a solo farmer who has to grow crops to survive and generate cash flow. During the day, you plant crops and gather resources to upgrade your farm. During the night, monsters come out and try to steal your crops. You have to defend the farm using various resources that can be obtained with the economy (ex. Fences, turrets, pets, etc.). If the monsters manage to hit you or take all your crops, you will lose the game. The nights will get progressively harder (3 levels) until you win the game. The game will be controlled using first-person. 

There will be two types of enemies. One will destroy your crops. The other will try to kill you. As the levels progress, more of them will spawn. As mentioned before, if the enemy hits you, you lose. If you lose all your crops, you lose. The player will be able to defend their farm using various resources provided by the NPC merchant stationed in their house. 

You are assisted by a pet dog who will help gather crops and alert you to enemies. The farm will take place on simple terrain, and you will have a house to control your economy and buy resources to help you survive. The goal is to grow your farm, earn money, and survive increasingly difficult nights, balancing resource management and defense. 

**2 \- Five Fundamental Game Mechanics** 

**Physics:** There will be basic walking mechanics for your player. You will be able to pick up crops utilizing colliders.  
**Tactical Maneuvering:** The player must be positioned correctly to avoid high-level monsters and protect expensive crops. 

**Progression Mechanism:** The player must upgrade their farm by increasing the size and purchasing high-level crops. This way, they can earn more money and purchase weapons and tools to defeat monsters. There will be 3 levels that follow a simple pattern. Farm, earn money, upgrade, survive. During the day, the player will farm crops, earn money, and upgrade their farm. Then, at night, the player must survive against enemies. Then the cycle starts up again 2 more times. 

**In-Game Economy:** The player will plant crops, which can be sold for money to buy more seeds, and buy weapons or tools to stop monsters. 

**Social Interaction:** An NPC merchant will be stationed in your house, where you can buy all the resources you need (crops, land upgrades, tools, weapons, etc) 

**3 \- Content Inventory:** 

**Player:** 

First Person Controller with jump and movement 

https\://assetstore.unity.com/packages/tools/input-management/mini-first-person-c ontroller-174710 

**Environment:** 

https\://assetstore.unity.com/packages/3d/environments/industrial/low-poly-farm-p ack-lite-188100 

https\://assetstore.unity.com/packages/3d/vegetation/trees/free-trees-103208 

**Pickups/Farm Essentials:** 

https\://assetstore.unity.com/packages/3d/environments/gamedev-starter-kit-farmi ng-free-edition-243035 

**NPC Merchant:** 

https\://assetstore.unity.com/packages/3d/characters/humanoids/fantasy/stylized npc-peasant-nolant-demo-252440  
**Monsters:** 

https\://assetstore.unity.com/packages/3d/characters/creatures/rpg-monster-duo-p br-polyart-157762 

**Pet:** 

https\://assetstore.unity.com/packages/3d/characters/animals/mammals/3d-stylize d-animated-dogs-kit-284699 

**4 \- Working Title:** 

“Farm Guardian” 

**Modifications to Original Design** 

For the final design I had to simplify my design due to complexity. Instead of creating night and day cycles, which was in my original plan, I just created 4 phases of the game. Planting phase, wave 1, planting phase, wave 2\. I also decided that implementing a cash system was extensive. Instead, I had corn as my main economy which the player gathers and buys items from the shop. Also my pet functionality changed. The pet only attacks the enemies that steal the crops. 

**Re-Adjusted Game Mechanics** 

**Physics:** Player can purchase a tower from the store and stand on the tower to strategically throw rocks at enemies and get a height advantage 

**Tactical Maneuvering:** The player must be positioned correctly to avoid high-level monsters and protect expensive crops. The player can instantiate a tower to jump on, and they must strategically place fences to protect crops 

**Progression Mechanism:** The game has 4 phases. Planting phase, wave 1, planting phase, wave 2\. Each planting phase will be 3 minutes, where the player can plant crops and purchase items from the shop (For the purpose of time, the  
planting phase in the gameplay video is 1 minute). To get to the next planting phase, the player must destroy all monsters. The player must get past all waves by destroying the monsters to win the game. 

**In-Game Economy:** The player will plant corn, which can be used to plant more corn and buy items from the shop. 

**Social Interaction:** An NPC merchant will be stationed in your house, where you can buy all the resources you need (rocks, tower, and fences). Player presses E to interact with shop 

**Instantiation Methods:** 

Corn: Uses raycasting and tag “Ground” to instantiate corn seeds that grow into corn. 

Fences, Tower, Rocks: Uses fixed z distance to instantiate prefabs. Rocks are thrown with a physics rigidbody and adding a force (Force.mode impulse). 

**Pet Functionality:** 

The pet in my game attacks the monsters that attack the player’s crops. This uses a simple navmesh agent and triggers colliders to work. 

Gameplay video: 

[https\://drive.google.com/file/d/1maCWcG4BU48638gMZuTyfolHIpn88huF/view?usp=sharing](https://drive.google.com/file/d/1maCWcG4BU48638gMZuTyfolHIpn88huF/view?usp=sharing)

