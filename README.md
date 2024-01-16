### Overview
This Unity project was created with Unity 2019.3 and can be opened in the Unity Editor using **File->Open Project**. The project is licensed under the MIT license as given in **LICENSE.md**.

### Multiple Output Display Setup for Unity Editor
Setting up the Unity Editor environment for multiple output displays: When starting up the Unity Editor, only one Game view tab is shown on the desktop. Create two additional Game view tabs by clicking on the three vertical dots in the right-hand corner at the top of the Game view tab. Then select **Add tab->Game**. Assign each Game view tab to each of the displays by using the the drop-down menu at the top of the Game view tab. Display 1 shows the left-eye display, Display 2 shows the right-eye display, while Display 3 shows the preview screen. The new layout can be saved by selecting **Layout->Save Layout** on the toolbar. It can also be restored by selecting Layout on the toolbar and clicking on the name the new layout was given.

### Program Execution
To execute program via command line:
1. Open a Command Prompt and go to the folder where the game executable is located
2. Enter the following command (replace with your preferred values): **nnlenv.exe mainDisplay=1 leftDisplay=2 rightDisplay=3 forwardKey=a backKey=b rightKey=d leftKey=c pupilDistance=64** 

If the program is executed by double-clicking the game executable, you can choose the input for navigation, as well as the output for display via the GUI. 

To exit the game, press alt+F4 or the quit button.

### Missing Assets Setup
Add required TestMesh Pro support to the project by selecting **Window->TextMeshPro->Import TMP Essential Resources**. Several required assets are not included due to license restrictions on redistribution.

Instructions for importing the required assets are as follows:
1. Download Unity from https://store.unity.com/
2. Create a Unity ID on https://id.unity.com/account/new
3. Find the following assets either by visiting the individual URLs and selecting "Open in Unity" or by searching up the names in the Asset Store inside the Unity Editor.
4. Import all the assets by selecting the "Import" button. Optional: Uncheck the Scenes folders/Scene files before importing, as this part of the assets are not required for the project.

Rob Luo - Townhouse:
https://assetstore.unity.com/packages/3d/environments/townhouse-142672

PoèMe - City Voxel Pack:
https://assetstore.unity.com/packages/3d/environments/urban/city-voxel-pack-136141

Art Georg - Sedan Car:
https://assetstore.unity.com/packages/3d/sedan-car-6751

VIS Games - Kiosk:
https://assetstore.unity.com/packages/3d/props/exterior/kiosk-2282

255 Pixel Studios - Simple City Pack:
https://assetstore.unity.com/packages/3d/environments/urban/simple-city-pack-plain-100348

Covalence Studios - US Road Signs Free:
https://assetstore.unity.com/packages/3d/props/exterior/us-road-signs-free-164941

VK GameDev - Asphalt Materials:
https://assetstore.unity.com/packages/2d/textures-materials/roads/asphalt-materials-141036

Mixaill - Building Constructor:
https://assetstore.unity.com/packages/3d/environments/urban/building-constructor-54469

LowlyPoly - Building Apartment:
https://assetstore.unity.com/packages/3d/environments/building-apartment-80004

Thunderent's Assets - Fountain Prop:
https://assetstore.unity.com/packages/3d/fountain-prop-75912

Revision3 - Simple Grid Shader:
https://assetstore.unity.com/packages/tools/simple-grid-shader-119988
