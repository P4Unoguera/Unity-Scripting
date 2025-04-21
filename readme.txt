Once I have finished the first part of "Introduction to Unity Scripting" tutorial, I have done its second part. That includes:
- Creation and implementation of the sheep spawns (handle lists and add/remove of game objects).
- Add visual enhancements and score track, to improve experience.
- Add sound effects with a Sound Manager.
- Manipulating User Interface, add a Game UI (title scene, game over window).
- Changing the user Hay Machine color.

Furthermore, I add some little features in order to improve the game. 

Firstly, I fixed a sheep drop issue. After implementing the second part of the tutorial, I faced a problem where dropping a sheep counted as two sheep falling. To solve it, I followed the same approach as handling the hitByHay proccess. That is creating a boolean variable "dropped" to identify when a sheep has fallen or not. This ensures the DroppedSheep() function is only called once, handle correctly the number of sheeps dropped.

Next, I have done a simple script called SheepDancing() to make the two sheeps of the title scene do a little "dance" by changing its rotation separatly. And I also add the smoke particles of the Hay Machine in the title scene.

Moreover, I have include a Game Win Window by duplicating the existing Game Over Window and creating a new variable called "sheepSavedBeforeGameWin", then when we achieve the goal of saved sheeps the Game Win Window pops up.

Finally, I have changed the audio clips of some of the actions and add many other sound effects to improve the experience.
- Change of the sheep drop sound -> Short Whistle Fall: https://mixkit.co/free-sound-effects/falling/
- Add sound effect when losing the game -> Musical game over: https://mixkit.co/free-sound-effects/discover/gameover/
- Add sound effect when winning the game -> WinBanjo: https://freesound.org/people/Fupicat/sounds/521640/
- Add background game theme loop -> Krasnodar Fury theme: https://freesound.org/people/SwimmingRock/sounds/647626/

In conclusion, while the new features and improvements do not alter the core gameplay, they refine the overall experience.
