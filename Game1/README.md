Note that the on-going proccess of this directory has been switched to a private repository. The commits from the private will be updated through this file below explaining the current state of the game.

Updates to the main game along with it's current progress will be recored here to give an idea where the project is at along with it's documentation.

---
<h3>Town RPG</h3>

<img src="gamePic.PNG"></img>

<h4>Version 0.03</h4>
* Enemys now get pushed back from player hits and turn red when hit.

<h4>Version 0.02</h4>
* Added basic lighting system (*back world light and object light*), placed into *Map* class.
* Added Attacking Animation
* Enemy Slime Added (*Random Movement and collision system*)
* Tile Drawing is now optimized for large maps. Before-hand all tiles on the map where looped and drawn, now tiles are stored in a 2D array and are directly accessed for drawing based on the player position (*the visible tiles on the screen*).
* Collisions are now optimized for large maps. Now colliadable items only check collision with it's neightbooring tiles.
* Bug Fixed: Enemy timers causing frame stuttering, timer has been re-implmented and optimized.
* Slimes now follow player when player is close based on a radius distance.
* Added Player attack rectangle (*for hitting enemies*)

<h4>Version 0.01</h4>
* Player and walking animations.
* Tilemapping system.
* Tile Collisions with player
* Player Sprinting mechanic (*basic*)
* Added Fullscreen mode along with scaling
* Added Door functionality, player can now move between maps using doorways

---

*Note:* A update will be made to this readme file whenever an importaint commit is made in the private directory of this project. 
