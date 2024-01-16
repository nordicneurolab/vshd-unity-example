using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed;
    public float rotationSpeed; 
    string forwardInputPref;
    string backInputPref;
    string leftInputPref;
    string rightInputPref;

    public CharacterController controller;
    public float gravity = -9.81f;

    Vector3 velocity;

    public Transform groundCheck;
    public LayerMask groundMask;
    public float groundDistance;
    bool isGrounded;
    int enableRotation; 

    //Keycodes
    KeyCode forward;
    KeyCode back;
    KeyCode left;
    KeyCode right;


    //constant strings for playerprefs methods
    private const string forwardInput = "forwardInput";
    private const string backInput = "backInput";
    private const string leftInput = "leftInput";
    private const string rightInput = "rightInput";
    private const string rotationInput = "rotationInput";


    void Start()
    { 

        forwardInputPref = PlayerPrefs.GetString(forwardInput);
        forward = (KeyCode)Enum.Parse(typeof(KeyCode), forwardInputPref);
        backInputPref = PlayerPrefs.GetString(backInput);
        back = (KeyCode)Enum.Parse(typeof(KeyCode), backInputPref);

        leftInputPref = PlayerPrefs.GetString(leftInput);
        left = (KeyCode)Enum.Parse(typeof(KeyCode), leftInputPref);

        rightInputPref = PlayerPrefs.GetString(rightInput);
        right = (KeyCode)Enum.Parse(typeof(KeyCode), rightInputPref);

        enableRotation = PlayerPrefs.GetInt(rotationInput);

    }


    void Update()
    {
        if (PlayerController.canMove)
        {
            moveSpeed = 0.7f;
            rotationSpeed = 30.0f; 
        }else
        {
            moveSpeed = 0;
            rotationSpeed = 0; 
        }

        if (Input.GetKey(forward))
        {
            controller.Move(transform.forward * moveSpeed * Time.deltaTime);
            velocity.y += gravity * Time.deltaTime;
            controller.Move(velocity * Time.deltaTime);
        }

        if (Input.GetKey(back))
        {
            controller.Move(-transform.forward * moveSpeed * Time.deltaTime);
            velocity.y += gravity * Time.deltaTime;
            controller.Move(velocity * Time.deltaTime);
        }

        if (Input.GetKey(left))
        {
            if (enableRotation == 1) {
                controller.transform.Rotate(-transform.up * rotationSpeed * Time.deltaTime);
            } else
            {
                controller.Move(Vector3.left * moveSpeed * Time.deltaTime);
            }
            velocity.y += gravity * Time.deltaTime;
            controller.Move(velocity * Time.deltaTime);
        }

        if (Input.GetKey(right))
        {
            if (enableRotation == 1)
            {
                controller.transform.Rotate(transform.up * rotationSpeed * Time.deltaTime);
            } else
            {
                controller.Move(-Vector3.left * moveSpeed * Time.deltaTime);
            }
            velocity.y += gravity * Time.deltaTime;
            controller.Move(velocity * Time.deltaTime);
        }
    }
}
