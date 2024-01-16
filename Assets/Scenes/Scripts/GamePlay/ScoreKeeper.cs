using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//score keeper
public class ScoreKeeper : MonoBehaviour
{
    //how many objects are found
    public static int found;
    //indicates if player has completed looking for the object
    public static bool success;

    //checks if all objectives are found
    public static bool Finish()
    {
        return found == ObjectController.imageObjects.Length;
    }


}
