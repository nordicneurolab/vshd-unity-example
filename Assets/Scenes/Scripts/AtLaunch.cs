using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//handles the command line arguments
public class AtLaunch : MonoBehaviour
{
    // constant strings for commmand line args
    private const string leftCDisplay = "leftDisplay=";
    private const string rightCDisplay = "rightDisplay=";
    private const string mainDisplay = "mainDisplay=";
    private const string leftKey = "leftKey=";
    private const string rightKey = "rightKey=";
    private const string forwardKey = "forwardKey=";
    private const string backKey = "backKey=";
    private const string rotation = "rotation=";
    private const string pupilDist = "pupilDistance=";

    //constant strings for playerprefs methods
    private const string leftDisplay = "leftDisplay";
    private const string rightDisplay = "rightDisplay";
    private const string BDDisplay = "BDDisplay";
    private const string forwardInput = "forwardInput";
    private const string backInput = "backInput";
    private const string leftInput = "leftInput";
    private const string rightInput = "rightInput";
    private const string rotationInput = "rotationInput";
    private const string pupilDistanceInput = "pupilDistance";

    //variables to be saved
    public int leftD; 
    public int rightD; 
    public int barrelDistortionD; 
    private string forward;
    private string back;
    private string left;
    private string right;
    private int pupilDistance;
    private int enableRotation;
    void Start()
    {

        string[] args = Environment.GetCommandLineArgs();
        if (CommandLineArgsIsCustomed(args))
        {
            ReadCommandLineArgs(args);
            SceneManager.LoadScene(2);
        }
        else
        {
            SceneManager.LoadScene(1);
        }
    }

    //returns true if custom command line args 
    private bool CommandLineArgsIsCustomed(string[] arguments)
    {
        string[] args = arguments;
        bool value = false;

        for (int i = 0; i < args.Length; i++)
        {
            if (args[i].StartsWith("leftDisplay=") == true)
            {
                value = true;
                break;
            }
        }
        return value;
    }

    private void ReadCommandLineArgs(string[] arguments)
    {
        string[] args = arguments;
        string argumentString;

        for (int i = 0; i < args.Length; i++)
        {
            argumentString = "";
            if (args[i].StartsWith(leftCDisplay) == true)
            {
                argumentString = args[i].Replace(leftCDisplay, "");
                Int32.TryParse(argumentString, out leftD);
                leftD = leftD - 1;
            }
            else if (args[i].StartsWith(rightCDisplay) == true)
            {
                argumentString = args[i].Replace(rightCDisplay, "");
                Int32.TryParse(argumentString, out rightD);
                rightD = rightD - 1;
            }
            else if (args[i].StartsWith(mainDisplay) == true)
            {
                argumentString = args[i].Replace(mainDisplay, "");
                Int32.TryParse(argumentString, out barrelDistortionD);
                barrelDistortionD = barrelDistortionD - 1;
            }
            else if (args[i].StartsWith(leftKey) == true)
            {
                argumentString = args[i].Replace(leftKey, "");
                left = argumentString.ToUpper();
            }
            else if (args[i].StartsWith(rightKey) == true)
            {
                argumentString = args[i].Replace(rightKey, "");
                right = argumentString.ToUpper();
            }
            else if (args[i].StartsWith(forwardKey) == true)
            {
                argumentString = args[i].Replace(forwardKey, "");
                forward = argumentString.ToUpper();
            }
            else if (args[i].StartsWith(backKey) == true)
            {
                argumentString = args[i].Replace(backKey, "");
                back = argumentString.ToUpper();
            }
            else if (args[i].StartsWith(rotation) == true)
            {
                argumentString = args[i].Replace(rotation, "");
                if (argumentString.Equals("on"))
                {
                    enableRotation = 1;
                } else
                {
                    enableRotation = 0;
                }
                
            }
            else if (args[i].StartsWith(pupilDist) == true)
            {
                argumentString = args[i].Replace(pupilDist, "");
                Int32.TryParse(argumentString, out pupilDistance);
                
            }
        }
        PlayerPrefs.SetInt(leftDisplay, leftD);
        PlayerPrefs.SetInt(rightDisplay, rightD);
        PlayerPrefs.SetInt(BDDisplay, barrelDistortionD);
        PlayerPrefs.SetString(forwardInput, forward);
        PlayerPrefs.SetString(leftInput, left);
        PlayerPrefs.SetString(rightInput, right);
        PlayerPrefs.SetString(backInput, back);
        PlayerPrefs.SetInt(pupilDistanceInput, pupilDistance);
        PlayerPrefs.SetInt(rotationInput, enableRotation);
    }

}


