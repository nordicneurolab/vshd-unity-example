using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleVisibility : MonoBehaviour
{
    /** 
     * Toggles the visibility of a game object.
     * **/
    [SerializeField]  public GameObject myobject;
    [SerializeField]  public bool activateme; 
        
    void Update()
    {
        if (activateme == true)
        {
            myobject.SetActive(true); 
        } else
        {
            myobject.SetActive(false); 
        }
    }
}
