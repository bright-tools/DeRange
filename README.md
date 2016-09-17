# DeRange
Desktop Arrangement Tool for Windows

This is a work-in-progress tool to allow users to create & save layouts of 
windows according to their preferences & then restore these layouts at a later 
date without having to manually drag and re-size the windows.

In order to do this, the user defines 3 classes of item:
* Windows - These are the attributes by which a window will be recognised
* Locations - These are the areas of the screen which a window will occupy
* Arrangements - Specify which Windows should be placed at which Locations (and also define suplementary details such as hotkeys)

## Why?

I have particular window layouts which I like to use, with some variation
depending on the task I'm working on.  If I reboot my machine (or undock my
laptop), it's necessary to manually re-arrange the windows.  The aim of this
tool is to do that automatically, based on a flexible configuration and hotkeys.

## Quick Overview

### Configuring a Window

The window configuration dialog allows you to set up a number of windows:

![Window configuration dialog](https://raw.githubusercontent.com/bright-tools/DeRange/master/assets/tutorial/window.PNG)

For each window you tell DeRange what to look for when it's trying to match
against the actual windows on your desktop.

| Item | Description |
|------|-------------|
| Name | Just a name by which to refer to the windown in other parts of DeRange
|
| Window Title | The text which DeRange will look for in the window's title bar
|
| Window Class | The class of window which DeRange will look for |
| Window EXE | The executable used to launch the window |

In the example above:
* The name assigned this is 'Visual Studio'.  This has no effect with regard to matching the window, it just gives us a convenient way to refer to the window
* For the window title, a [https://en.wikipedia.org/wiki/Regular_expression](regular expression) is used
* Matching on the window class and executable is not enabled (the 'Match Enabled' boxes are not ticket for these attributes

## Download

Installers are available for download within the [https://github.com/bright-tools/DeRange/releases]("Releases") area.

(Yes, it's Windows only)
