using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustPupilDistance : MonoBehaviour
{
    public Camera rightEye;
    public Camera rightEyePreview; 
    public float pupilDistance; 

    //constant string for playpref
    private const string pupilDistanceInput = "pupilDistance";

    void Start ()
    {
        //set the position of the right camera based on pupil distance
        pupilDistance = (float)(PlayerPrefs.GetInt(pupilDistanceInput))/1000;
        rightEye.transform.localPosition = new Vector3(pupilDistance, 0, 0);
        rightEyePreview.transform.localPosition = new Vector3(pupilDistance, 0, 0);
    }
}
