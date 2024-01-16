using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.Events;

//handles which object will be the objective, and which object pops up on the screen
public class ShowImageController : MonoBehaviour
{
 
    public static IEnumerator ShowImage()
    {
        
        GameObject a = ObjectController.imageObjects[ScoreKeeper.found];
        //saves the objective name to keep track of the objective
        ObjectContainer.objectiveName = a.name;
        //show image for five sec
        a.SetActive(true);
        yield return new WaitForSeconds(5f);
        //hide image
        a.SetActive(false);
        Tracker.showObjective = false;
        Tracker.find = true;
 

    }


}
