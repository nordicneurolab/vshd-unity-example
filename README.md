### Overview
This Unity project was created with Unity 2022.3 and can be opened in the Unity Editor using **File->Open Project**. The project is licensed under the MIT license as given in **LICENSE.md**.

This work creates a 3D/Virtual Reality (VR) environment in Unity which could be integrated with the NordicNeuroLab (NNL) VisualSystem HD (VSHD) for providing visual stimulation when performing fMRI scans on a subject or patient. The NNL ResponseGrips could be used as the subject/patient's movement input. 

<img width="932" alt="Screenshot 2024-01-16 at 13 32 22" src="https://github.com/nordicneurolab/vshd-unity-example/assets/122446560/22815586-36d7-4914-8387-fb294136773c">


### Multiple Output Display Setup for Unity Editor
When starting up the Unity Editor, only one Game view tab is shown on the desktop. Create two additional Game view tabs by clicking on the three vertical dots in the right-hand corner at the top of the Game view tab. Then select **Add tab->Game**. Assign each Game view tab to each of the displays by using the the drop-down menu at the top of the Game view tab. Display 1 shows the left-eye display, Display 2 shows the right-eye display, while Display 3 shows the preview screen. The new layout can be saved by selecting **Layout->Save Layout** on the toolbar. It can also be restored by selecting Layout on the toolbar and clicking on the name the new layout was given.

### Program Execution
The program can be executed by clicking on the game executable or via the command line.

To execute program via command line:
1. Open a Command Prompt and go to the folder where the game executable is located
2. Enter the following command (replace with your preferred values): **nnlenv.exe mainDisplay=1 leftDisplay=2 rightDisplay=3 forwardKey=a backKey=b rightKey=d leftKey=c pupilDistance=64** 

If the program is executed by double-clicking the game executable, you can choose the input for navigation, as well as the output for display via the GUI. 

To exit the game, press alt+F4 or the quit button.

### Acknowledgements

Over the spring 2020, NordicNeuroLab collaborated with two students, Arja Sivapiragasam and Enah Lanto, from the Western Norway University of Applied Sciences on the completion of their bachelor’s degree in computer science. Their thesis work focused on creating a sample project on how to use Unity with the NordicNeuroLab VisualSystem HD. The gameplay, pre distortion shader and multiple other game components are derived from their project. 

Every asset in this project is either under **The Unlicense** or **CC0**. 

The optional grid and its shader is written by r3eckon under **The Unlicense** license:

 - https://github.com/r3eckon/Unity-SimpleGrid-Shader/tree/master

The nature assets are made by Quaternius and are under the **CC0** license:

 - https://gdevelop.io/es-es/asset-store/free/3d-rocks-and-trees-3d-rocks-and-trees

The road assets as well as all the buildings in the scene are also released under the **CC0** license by Kenney:

 - https://www.kenney.nl/assets/city-kit-roads
 - https://www.kenney.nl/assets/city-kit-commercial
