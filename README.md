# DeRange
Desktop Arrangement Tool for Windows

This is a work-in-progress tool to allow users to create & save layouts of 
windows according to their preferences & then restore these layouts at a later 
date without having to manually drag and re-size the windows.

In order to do this, the user defines 3 classes of item:
* Windows - These are the attributes by which a window will be recognised
* Locations - These are the areas of the screen which a window will occupy
* Arrangements - Specify which Windows should be placed at which Locations (and also define suplementary details such as hotkeys)

![demo](https://raw.githubusercontent.com/bright-tools/DeRange/master/assets/demo.gif)

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
| Name | Just a name by which to refer to the window in other parts of DeRange |
| Window Title | The text which DeRange will look for in the window's title bar |
| Window Class | The class of window which DeRange will look for |
| Window EXE | The executable used to launch the window |

In the example above:
* The name assigned this is 'Visual Studio'.  This has no effect with regard to matching the window, it just gives us a convenient way to refer to the window
* For the window title, a [regular expression](https://en.wikipedia.org/wiki/Regular_expression) is used
* Matching on the window class and executable is not enabled (the 'Match Enabled' boxes are not ticket for these attributes

### Configuring Locations

The location configuration dialog allows you to create locations in which
windows will be placed

![Window location dialog](https://raw.githubusercontent.com/bright-tools/DeRange/master/assets/tutorial/location.PNG)

The data in this dialog specifies the changes which will be applied to a window.

| Item | Description |
|------|-------------|
| Name | Just a name by which to refer to the location in other parts of DeRange |
| X Pos, Y Pos | X and Y co-ordinates for the top-left of the window.  The tick-box to the right indicates whether or not the window should be moved to this location or just left where it is. |
| Width, Height | The width and height for the window.  The tick-box to the right indicates whether the window should be resized or left as it is. |
| Maximised... | This drop-down allows other behaviour, such as minimising or maximising the window.  Note that window '0' is your main window (not necessarily the left-most one!) |

In the example above:
* The name assigned is 'Main Monitor Max'.  This has no effect with regard to the location settings, it just gives us a convenient way to refer to the location.
* The setting for this is to maximise the window on monitor 0, the main monitor

### Arrangements

The arrangement configuraiton dialog allows you to create arrangements of a
number of windows

![Arrangement dialog](https://raw.githubusercontent.com/bright-tools/DeRange/master/assets/tutorial/collection.PNG)

The data in this dialog specifies the contents of the arrangement and
attributes.

| Item | Description |
|------|-------------|
| Name | Just a name by which to refer to the arrangement |
| Keyboard Shortcut | These controls allow the user to specify the keyboard
shortcut associated with the arrangement.  The shortcut won't be active until
the dialog is closed. |
| Set Z-Index ... | The windows will appear on the screen in the order in which they appear in the list, i.e. the windows at the top will appear above those lower down |
| Add, Update ... | These buttons allow the user the change which windows and locations are contained within the arrangement |

In the example above:
* There are 2 windows (with associated locations) within an arrangement called 'Coding'
* The 'Coding' arrangement will be bound to the keyboard shortcut Shift+Win+F1
* The windows will be depth arrangement in order, so the Visual Studio window will appear above the Terminal window. 
* Any windows which don't match those in the list will be moved to the back.

## Download

Installers are available for download within the ["Releases"](https://github.com/bright-tools/DeRange/releases) area.

(Yes, it's Windows only)
