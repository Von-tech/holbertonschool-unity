# 0x05. Unity - Assets: Models, Textures

Skyboxes: Farland Skies - Cloudy Crown


What you'll find? This part of my Learning process is about:
- What is an Asset and how to import and use them
- How to use Asset Packages and the Unity Asset Store
- What are common Asset types
- How to use Unity primitives as placeholders to prototype a project
- What are materials and how to use them
- What are textures and how to use them
- What is a skybox
- What is are the components of a 3D model
- What is a mesh
- How to create UI elements with image components
- What is a Rigidbody and what is a Character Controller and what are the pros and cons of using each
- What is a Quaternion

Here are the task I solve to answer those question and more. The solution to every task is on the file with the same name than the task.

My challenge for you is to try to solve all of this task and after see the way I did it.

This is a project made on Unity 2019.3.0f6. If you have a different version of Unity, you can try to open the project and see if it works. If it doesn't, you can try to update your version of Unity.

This project have deploy to windows, linux and mac platform.

#### 0. Primitive player
Create a new Scene called `Level01`. Create a capsule GameObject called `Player` which will be a placeholder for this project.

Position: `X: 0`, `Y: 1.25`, `Z: 0`
Rotation: `X: 0`, `Y: 0`, `Z: 0`
Scale: `X: 1`, `Y: 1`, `Z: 1`
Save `Player` as a Prefab into a folder named `Prefabs`. Make sure that when you make changes to the `Player` Prefab, you Apply the changes at the top of the Inspector window.

#### 1. Primitive prototype
In the `Level01` scene, create a layout of floating platforms of different sizes and positions using only Unity Cube GameObjects, . Plan for a start point and an endpoint and create a path so that the `Player` can jump between them. The cubes will be placeholders for 3D models that we will import later on.

![image1](Images/1a.png)

- We strongly suggest drawing out your level layout on paper or whiteboard before building it in Unity
- Create an empty GameObject called `Platforms` with a position of `X:0`, `Y:0`, `Z:0` and organize your platform GameObjects inside it
- The first platform should be positioned underneath the `Player`
- Feel free to create multiple paths or dead ends but keep the number of platforms under 30
- You may find it useful to use a top down or side view with the Scene Gizmo to position your platforms

![image2](Images/1b.png)

#### 2. Pole position
At the end point of the platforms, create a placeholder cylinder GameObject called `WinFlag` to designate the end of the path. Do not make `WinFlag` a child of any object. Later we will add scripting for when the `Player` reaches the `WinFlag`.
- Capsule Collider:
    - `isTrigger`: Yes
    - `Radius`: `0.7`
    - `Height`: `6`

![image3](Images/2.png)


#### 3. Jump man
Create a new folder called `Scripts`. Inside that folder, create a new C# script called `PlayerController` and attach it to `Player`.

- The script should handle user input so the player can move left, right, forward, backward, and diagonally using the WASD keys
- The player should jump when the Space button is pressed
![gift1](Images/3.gif)


#### 4. Camera ready
Position the `Main Camera` at an offset behind the player.

Position: `X: 0`,` Y: 2.5`, `Z: -6.25`
Rotation: `X: 9`, `Y: 0`, `Z: 0`
![image4](Images/4.png)


#### 5. Steady cam
In the Scripts folder, create a new C# script called `CameraController` that allows the camera to follow the player. The script should also allow the player to rotate the camera on their own by moving the mouse, either by just moving the mouse or holding down right-click and dragging the mouse to move the camera.
![gift2](Images/5.gif)


#### 6. Falling up
Currently if the player falls off a platform, it falls infinitely. Edit the `PlayerController` and `CameraController` scripts so that if the player falls from a platform and can’t get to another platform, the player instead falls from the top of the screen onto the start position, causing the player to need to start from the beginning again.
![gift3](Images/7.gif)

Test your game and check your platform layout, making sure it’s possible to reach the end and that the player’s jump and movement works correctly. You may need to adjust your player’s jump or your platforms’ positioning / size.

#### 7. Time trial
Create a new Canvas and UI Text element that displays a timer on screen.
- Canvas Name: `TimerCanvas`
    - Pixel Perfect: No
    - UI Scale Mode: `Scale With Screen Size`
    - Reference Resolution: `X: 1280` `Y: 800`
    - Screen Match Mode: `Match Width or Height`
    - Match: `1` (Height)
- Text GameObject Name: `TimerText`
- Width: `160`
- Height: `30`
- Anchor: `Top`, `Center`
- Position: `X: 0`, `Y: -40`, `Z: 0`
- Text: `0:00.00`
- Font size: `48`
- Font color: `White`
- Alignment: `Center`, `Middle`
- Horizontal Overflow: `Overflow`
- Vertical Overflow: `Overflow`

Save `TimerCanvas` as a Prefab. Make sure that when you make changes to the `TimerCanvas` Prefab, you Apply the changes at the top of the Inspector window.
![image5](Images/5.png)


##### 8. Clock's ticking
Create a script called `Timer` and attach to the `Player`. `Timer` should have a public Text variable called `Timer Text` for the TimerText Text object.

The timer should start at `0:00.00` and count up.
![gift4](Images/9.gif)

Currently, the timer starts as soon as the scene loads. Instead, we want the timer to start as soon as the Player starts moving. Disable the `Timer` script attached to `Player`. Leave the `TimerCanvas` active so that `0:00.00` is displayed.

Create a Cube GameObject called `TimerTrigger`.

Position: `x: 0`, `y: 1.25`, `z: 0`
Scale: `x: 0`, `y: 2`, `z: 0`
Disable the Mesh Renderer
Create a new script called `TimerTrigger` and attach it to the `TimerTrigger` GameObject. This script should enable the `Timer` script and start counting up as soon as the Player exits the `TimerTrigger`‘s Collider.

If the Player falls and restarts, the timer should **not** reset – it should continue to run.
