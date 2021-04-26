# cyber-secured
Repository for academic game project Cyber Secured

## Requirements
* Unity@2018.2.13
* a preferred code editor, Microsoft Visual Studio was used for the development of this project

## Start Up

* Launch Unity
* Open PROJ-4900---Cyber-Security-Game-master folder
* Press Play and validate that the game is running, can press Play icon again to stop 
* Launch VS Studio, open the same PROJ-4900---Cyber-Security-Game-master folder
* Starting point is in Assets/Scripts/GameControllerV2.cs, which controls which Month to display and what falls under that Month.
* Modifications to the game can be done in the Unity GUI and in a code editor.

## Build

In Unity:

* File > Build Settings
* Pick desired build Module (tested with WebGL)
* Hit Build > choose desired build location 
	* If build is taking a while, recommend opening up Task Manager (ctrl + alt + del), check and close other memory-intensive processes to free up more memory

## Test Out Build Locally

Several ways, in Unity you can press build and run, in the background unity will spin up a server for your build to run on to be viewed in a browser.

Recommended: install and use to start up a localserver https://www.npmjs.com/package/local-web-server 
after installing, navigate via command prompt to the build location where "index.html" and start up server with "ws"

Then, in your browser, visit http://localhost:8000, or whatever prints out in command prompt.