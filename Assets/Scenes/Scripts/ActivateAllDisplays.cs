using UnityEngine;
using System.Collections;

public class ActivateAllDisplays : MonoBehaviour
{
    //constant strings for playerprefs methods
    private const string leftDisplay = "leftDisplay";
    private const string rightDisplay = "rightDisplay";
    private const string BDDisplay = "BDDisplay";

    public Camera leftCam;
    public Camera rightCam;
    public Camera BDCam;
    public Camera PreviewLeft;
    public Camera PreviewRight;
    int leftD;
    int rightD;
    int barrelDistortionD;

    public void Start()
    {
        //get player preferences 
        leftD = PlayerPrefs.GetInt(leftDisplay);
        rightD = PlayerPrefs.GetInt(rightDisplay);
        barrelDistortionD = PlayerPrefs.GetInt(BDDisplay);

        //set target displays for each camera
        rightCam.targetDisplay = rightD;
        leftCam.targetDisplay = leftD;
        BDCam.targetDisplay = barrelDistortionD;
        PreviewLeft.targetDisplay = barrelDistortionD;
        PreviewRight.targetDisplay = barrelDistortionD;

        for (int i = 1; i < Display.displays.Length; i++)
        {
            Display.displays[i].Activate();
        }



    }

}
