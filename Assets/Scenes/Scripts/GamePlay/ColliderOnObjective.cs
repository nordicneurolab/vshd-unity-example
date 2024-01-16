using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//handles interaction between the traffic sign and the player
public class ColliderOnObjective : MonoBehaviour
{
    public GameObject trafficSign;
    private static bool found;


    public static IEnumerator Finding()
    {
        yield return new WaitUntil(() => found == true);
        found = false;
    }

    private void OnTriggerEnter(Collider other)
    {

        ImageSwitch.showOnConfirm = true;

        if (correctObject())
        {
            ScoreKeeper.success = true;
        }
        else
        {
            ScoreKeeper.success = false;
        }
        found = true;
    }
    //checks if the correct traffic sign is selected
    private bool correctObject()
    {
        return ObjectContainer.objectiveName.Equals(trafficSign.name);
    }

}