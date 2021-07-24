# Flappy Drone

## Project Description
The purpose of this design document is to describe the details for the Flappy Droid. The goal of this game is to fly through the pillar and score points. If the Droid comes into contact with a pillar the game will end. 


## Scrolling Background

Added a night background with stars. Created a material and wrote a script to offset the image to provide a moving background effect.
 
## Sound Effect 

- Added a sound effect when the player jumps
- Added a sound effect when the player dies 
- Added background sound when playing the game 

# Main & Death Scenes
3.1 Main Menu:
Background:
The background is a gradient orange color that will show the energy of the came. Also, the reality of it; it can be lighter and easy, but it can be dark and difficult.

# Main Menu: 
We wanted to show the title in a big and nice font where the player could feel the urgency to play right away and let the player know of the name of the game; make it unforgettable and easy to read.
Death Menu: 
The idea behind this death screen is to highlight that the player has died by choosing a strong red color. The intensity of this scene will show the player how bad it feels to lose. 

### Buttons:
We have a variation of buttons. We have four buttons for the main menu scene and four more for the death scene. The player only sees two buttons per scene, not four. This happens because we decided to animate the action to when the player hovers over each button. This is where a variation of a respective button shows up. It is the same strategy for the death scene. 

### Drones:
Since the game is called “Fluppy Drone”, we decided to show the player what the drone will be; how it would look when the player emerges into this world. Going beyond, the color of the drone matches our main menu scene.

## New Graphics:
Added a night sky background and added some movement to the background to cause a parallax effect. This gives the drone a moving notion when it actually is not moving.  

## Scoring System 

### Current Score: 
When starting the game, we display a text saying “Score” followed by an TMPro text for the update showing the value zero.

### Score Update:
We will take our current value and will add one to it. 

### Design:
The idea is straightforward. If the drone passes through the pipes, we add one to the current score. The first approach taken was to get the y value of the pipes and check if is < 0. If it is, that means we didn’t hit the pipes or fall down; we didn’t die. 
Otherwise, we die. This was a little problematic because we needed to get the y value and do some dragging of the pipes.. so we decided to go with a different approach. The final approach was to throw an empty game object in the middle of the pipes and add a collider in between pipes. Checked the box that says “is trigger”. 

### Increasing the Difficulty of the Game
The difficulty of the game will depend on the score. The first change will be at the first 20 times the player successfully crosses the pipes. We will speed up the velocity in which the pipes spawns. The second time it will be at 40 points. Then, the following will be at 60 and 80 or greater. This is when we define rules to know when to increase the difficulty and by how much. We have four rules in which the speed will increase, but two of them are the same. Bellow we will find the three rules
 
- The pipes will spawn 10.0f faster than the current speed.
- The pipes will spawn 5.0f farther than the current speed.
- The pipes will spawn 8.0f faster than the current speed. 
