using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationLook : MonoBehaviour
{
    /**
     * This class is not utilized but could be useful for further development with eye tracking
     * **/
    public float mouseSensitivity = 100f;

    //to link up rotation of camera in relation to the body
    public Transform playerBody;

    public Transform canbas;
    //to rotate around x axis
    float xRotation = 0f;


    // Start is called before the first frame update
    void Start()
    {
        //lock the cursor
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {       
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

            xRotation -= mouseY;
            // to make sure youre not gonna overrotate
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            //applying rotation
            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            playerBody.Rotate(Vector3.up * mouseX);
        
  





    }
}
