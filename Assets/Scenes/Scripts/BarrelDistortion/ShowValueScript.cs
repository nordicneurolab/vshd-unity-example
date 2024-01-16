using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class ShowValueScript : MonoBehaviour
{
    /** 
     * To show the value of distortion as the slider value changes
     * **/
    public TextMeshPro KCValueText;
    //Text kText; 
    // Start is called before the first frame update
    void Start()
    {
        KCValueText = GetComponent<TextMeshPro>();
       // kText = GetComponent<kText>();

    }

    // Update is called once per frame
    public void textUpdate(float value)
    {

        if (KCValueText != null)
        {
            // Round float value to 2 decimals 
            value = Mathf.Round(value * 100.0f) * 0.01f;

            //Update text
            KCValueText.text = "value = " + value;
        }
    }
}
