### Andrey Kolybelnikov

### andrey@gatech.edu

### akolybelnikov3

### Roll a Ball: Foundation level Unity3D game adopted from the [Unity Learning tutorial](https://learn.unity.com/project/roll-a-ball-tutorial?uv=2019.3)

### Requirements

#### Step 1

- Completed the Unity Tutorial
- Created the Game Scene, Ground, Walls, Player (Ball) and Collectible Objects with regarding Scripts, Materials and Pre-Fabs
- Adjusted the Light and connected the Camera to the Playet with the CameraController script
- Added rotation to the Collectible Objects (Pick Ups)
- Created the canvas with the Score and Win Texts

#### Step 2

- Added my name to the canvas

#### Step 3

- Added a Particle Pre-Fab to create a collision effect every time the Player scores a Collectible
- Modified the Particle properties in the Unity UI: color, lifetime, speed and form of rendering
- Modified the PlayerController Script to add a Particle to every Collision with a Pick Up
- Added an explicit instruction to remove the particle after the Collision event

```C#
public GameObject particle;
...
GameObject p = Instantiate(particle, other.gameObject.transform.position, Quaternion.identity) as GameObject;
...
Destroy(p, 1.5f);
```

- Changed `OnTriggerExit` event to be `OnTriggerEnter` to avoid the pass-through effect when the Player collides with a Collectible

#### Step 4

- Added SuperBouncy Material to the Walls to make the Player bounce off for better game dynamics
- Added Chaos GameObject and it's prefab with 2 Materials
- Chaos Balls move around uncontrollably and obstruct the Player's game
- If a collision with a Chaos Ball is too hard, the Player might bounce off beyond the Walls; in this case the Scene is re-spawned
- Changed the logic of the Count: the Player wins once all Pick Ups are collected

### Project Instructions

#### External resources

The project doesn't include any assets/resources acquired outside class.

#### Building and Running the code

The project submission includes a working build of the game with target platform OSX.
To regenerate the build the project can be added in the Unity Hub and opened in the Unity UI. After project files are re-created from the Project Settings, a new build can be run.

#### Grading

To check if the game meets the assignemnt requirements, the project can be run from the executive, or opened in Unity UI. The project includes only one scene.
