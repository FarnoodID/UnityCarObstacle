# UnityCarObstacle

This repository contains a Unity project for a 3D driving simulator that enables players to control both a vehicle and an airplane, navigating through various obstacles in a dynamic environment.

## Overview

The driving simulator project allows players to experience both ground and aerial navigation. Key components include:

- **Vehicle Control**: Implemented using C# scripts to manage movement and interactions on the ground.
- **Plane Control**: Allows users to fly an aircraft, controlling its pitch and navigation through the sky.
- **Obstacle Setup**: Various obstacles are placed in both the driving and flying environments to enhance gameplay.
- **Camera Mechanics**: A camera that follows the vehicle and plane for an immersive experience.

## Project Structure

The project is organized into several key folders and scripts:

- **Assets**: Contains all imported assets, including vehicle and plane models, as well as obstacle prefabs.
- **Scripts**: Includes C# scripts for controlling vehicle and plane behavior, as well as camera movement.
  - `PlayerController.cs`: Manages vehicle movement and speed.
  - `PlaneController.cs`: Handles flight mechanics for the airplane, including pitch control.
  - `FollowPlayer.cs`: Controls camera positioning to follow the vehicle or plane smoothly.

## Implementation Details

1. **Scene Setup**:
   - Created a new Unity project with a 3D template and imported necessary assets for vehicles, planes, and obstacles.

2. **Object Placement**:
   - Added a vehicle and an airplane to the scene, along with multiple obstacles positioned strategically both on the ground and in the air.

3. **Vehicle Movement**:
   - Developed the `PlayerController` script to enable forward motion using `transform.Translate` combined with `Vector3.forward`, with speed adjustable via a public float variable.

4. **Plane Movement**:
   - Created the `PlaneController` script to manage flight dynamics, allowing control of the plane's pitch using the up and down arrow keys.
   - Implemented constant forward movement for the plane while allowing user input to tilt its nose up or down.

5. **Collision Detection**:
   - Added Rigidbody components to both vehicles and obstacles to facilitate realistic physics interactions during collisions.

6. **Camera Follow**:
   - Implemented the `FollowPlayer` script to ensure the camera follows either the vehicle or plane smoothly, enhancing player experience.


## Features

- **Dynamic Vehicle Control**: Players can drive a vehicle using keyboard controls.
- **Aircraft Control**: Players can fly an airplane by tilting its nose up or down with arrow keys while maintaining constant forward motion.
- **Realistic Physics**: Collisions between vehicles/planes and obstacles are handled using Unity's physics engine.
- **Camera Mechanics**: The camera follows the player's vehicle or plane, providing an optimal view of the gameplay area.

## Getting Started

### Prerequisites
- Unity Hub installed with the 2018.4.24f1 version of Unity.
- Basic understanding of C# programming.

### Installation
1. Clone this repository:
   ```bash
   git clone https://github.com/FarnoodID/UnityCarObstacle.git
   ```
2. Open the project in Unity.
3. Ensure all necessary packages are installed.

## Controls
- W/S or Up/Down Arrows: Accelerate/Decelerate.
- A/D or Left/Right Arrows: Steer left/right.
