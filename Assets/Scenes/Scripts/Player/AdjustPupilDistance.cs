using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustPupilDistance : MonoBehaviour
{
    [SerializeField]
    private Camera rightEye;
    [SerializeField]
    private Camera leftEye;
    [SerializeField]
    private Camera rightEyePreview; 
    [SerializeField]
    private Camera leftEyePreview; 

    private float pupilDistance; 

    private Vector3 IPDTransform;

    //constant string for playpref
    private const string pupilDistanceInput = "pupilDistance";

    void Start ()
    {
        
        pupilDistance = (float)(PlayerPrefs.GetInt(pupilDistanceInput))/1000;

        IPDTransform = new Vector3(pupilDistance / 20, 0, 0);
        
        rightEye.transform.localPosition -=  IPDTransform;
        leftEye.transform.localPosition += IPDTransform;

        rightEyePreview.transform.localPosition -= IPDTransform;
        leftEyePreview.transform.localPosition += IPDTransform;
    }
}
