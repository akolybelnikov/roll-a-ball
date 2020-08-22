### Andrey Kolybelnikov
### andrey@gatech.edu
### akolybelnikov3

## Roll a Ball: Foundation level Unity3D game adopted from the (Unity Learning tutorial)[https://learn.unity.com/project/roll-a-ball-tutorial?uv=2019.3]
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
```
public GameObject particle;
...
GameObject p = Instantiate(particle, other.gameObject.transform.position, Quaternion.identity) as GameObject;
...
Destroy(p, 1.5f);
```
- Changed `OnTriggerExit` event to be `OnTriggerEnter` to avoid the pass-through effect
#### Step 4
- 