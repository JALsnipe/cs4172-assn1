COMS W4172: 3D User Interfaces and Augmented Reality
Steven Feiner 

Josh Lieberman
jal2238
jal2238@columbia.edu
Assignment 1: Unity in Space

Date of Submission: 2/25/2014

Development Environment:
Mac OS X Version 10.9.1
LG Nexus 5 running Android version 4.4.2

Project Title: cs4172-assn1
Scene Title: SolarSystem.unity

Directory Overview:
Assets/ - contains all project assets
Assets/_Scenes/ - contains a single scene file, SolarSystem.unity
Assets/Materials/ - contains all materials and skyboxes used
Assets/Scripts/ - contains all necessary C# script files
Assets/Standard Assets (Mobile)/ - imported Unity mobile assets

Special Instructions:
None, just build and run.  App should run in landscape mode.

Instructions:
App should be straightforward.  Camera controls appear on the left side of the
screen, planet/ship controls appear on the right side of the screen as objects
are selected.

Missing features:
-Camera pitch and yaw do not work correctly.
-Spaceship can rotate, but throttle not working (collisions do work, however).

Bugs in Code:
Nothing that would halt compliation, but one small Ray casting issue:
Rays cast to GUI buttons may hit planets.

Asset Sources:
https://www.assetstore.unity3d.com/#/content/2453 - Planet textures
https://www.assetstore.unity3d.com/#/content/3392 - Skybox
http://www.celestiamotherlode.net/catalog/moon.php - Moon texture map

Video Demo:
http://www.youtube.com/watch?v=JUJLo8AoCr8
Raw file: http://www.cs.columbia.edu/~jal2238/cs4172/