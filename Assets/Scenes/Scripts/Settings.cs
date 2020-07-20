using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using TMPro;

    public class Settings : MonoBehaviour
    {
    /** 
     * saves settings to playerprefs
     * **/
        public int leftD; 
        public int rightD; 
        public int barrelDistortionD; 
        private string forward;
        private string back;
        private string left;
        private string right;
        private int pupilDistance;
        private int enableRotation;
        [SerializeField] private GameObject inputField;

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


        //setting the default values here
        //because the event handler on the ui only tracks if the value has changed
        public void Start()
        {

            leftD = 0; //default first monitor, main
            rightD = 1; //default second monitor;
            barrelDistortionD = 2;
            pupilDistance = 64;
            enableRotation = 1;

            PlayerPrefs.SetInt(leftDisplay, leftD);
            PlayerPrefs.SetInt(rightDisplay, rightD);
            PlayerPrefs.SetInt(BDDisplay, barrelDistortionD);
            PlayerPrefs.SetInt(pupilDistanceInput, pupilDistance);
            PlayerPrefs.SetInt(rotationInput, enableRotation);

            forward = "A";
            back = "B";
            left = "C";
            right = "D";

            PlayerPrefs.SetString(forwardInput, forward);
            PlayerPrefs.SetString(backInput, back);
            PlayerPrefs.SetString(leftInput, left);
            PlayerPrefs.SetString(rightInput, right);
        }


        public void LeftDisplay(int val)
        {

            if (val == 0)
            {
                leftD = 0;
            }
            else if (val == 1)
            {
                leftD = 1;
            }
            else
            {
                leftD = 2;
            }
            PlayerPrefs.SetInt(leftDisplay, leftD);


        }

        public void RightDisplay(int val)
        {
            if (val == 0)
            {
                rightD = 1;
            }
            else if (val == 1)
            {
                rightD = 0;
            }
            else
            {
                rightD = 2;
            }
            PlayerPrefs.SetInt(rightDisplay, rightD);
        }

        public void BarrelDistortionDisplay(int val)
        {
            if (val == 0)
            {
                barrelDistortionD = 2;
            }
            else if (val == 1)
            {
                barrelDistortionD = 0;

            }
            else
            {
                barrelDistortionD = 1;
            }
            PlayerPrefs.SetInt(BDDisplay, barrelDistortionD);
        }

        public void SetForward(int i)
        {
            Debug.Log("SetForward method");
            switch (i)
            {
                case 0:
                    forward = "A";
                    break;
                case 1:
                    forward = "B";
                    break;
                case 2:
                    forward = "C";
                    break;
                case 3:
                    forward = "D";
                    break;
                case 4:
                    forward = "W";
                    break;
                case 5:
                    forward = "S";
                    break;
            }
            PlayerPrefs.SetString(forwardInput, forward);
        }

        public void SetBack(int i)
        {
            switch (i)
            {
                case 0:
                    back = "B";
                    break;
                case 1:
                    back = "A";
                    break;
                case 2:
                    back = "C";
                    break;
                case 3:
                    back = "D";
                    break;
                case 4:
                    back = "W";
                    break;
                case 5:
                    back = "S";
                    break;
            }
            PlayerPrefs.SetString(backInput, back);
        }

        public void SetLeftM(int i)
        {
            switch (i)
            {
                case 0:
                    left = "C";
                    break;
                case 1:
                    left = "A";
                    break;
                case 2:
                    left = "B";
                    break;
                case 3:
                    left = "D";
                    break;
                case 4:
                    left = "W";
                    break;
                case 5:
                    left = "S";
                    break;
            }
            PlayerPrefs.SetString(leftInput, left);
        }
        public void SetRightM(int i)
        {
            switch (i)
            {
                case 0:
                    right = "D";
                    break;
                case 1:
                    right = "A";
                    break;
                case 2:
                    right = "B";
                    break;
                case 3:
                    right = "C";
                    break;
                case 4:
                    right = "W";
                    break;
                case 5:
                    right = "S";
                    break;
            }
            PlayerPrefs.SetString(rightInput, right);
        }

        public void SetPupilDistance()
        {
            string PDInput = inputField.GetComponent<TMP_InputField>().text;

            bool parseSuccess = int.TryParse(PDInput, out pupilDistance);


            if (parseSuccess)
            {
                PlayerPrefs.SetInt(pupilDistanceInput, pupilDistance);
            }
            else
            {
                //legge rød farge på feltet?
                Debug.Log("Input was not a number");
            }
        }

        public void toggleRotation(bool b)
        {
            if (b == true)
            {
                enableRotation = 1;
            }
            else
            {
                enableRotation = 0;
            }

            PlayerPrefs.SetInt(rotationInput, enableRotation);
        }

        //load the game scene
        public void StartButton(string scene)
        {
            SceneManager.LoadScene(scene);
        }
    }
