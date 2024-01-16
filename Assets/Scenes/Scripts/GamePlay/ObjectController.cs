using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

//collects the objectives on the scene
public class ObjectController : MonoBehaviour
{
    public static GameObject[] gameObjects;
    public static GameObject[] imageObjects;
    private void Awake()
    {

        imageObjects = GameObject.FindGameObjectsWithTag("ImageObjective");
        gameObjects = GameObject.FindGameObjectsWithTag("Objective");

        foreach (GameObject o in imageObjects)
        {
            o.SetActive(false);
        }
    }

 
}

