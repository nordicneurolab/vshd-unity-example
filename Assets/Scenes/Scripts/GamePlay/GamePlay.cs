using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

//handles the flow of the game
public class GamePlay : MonoBehaviour
{
    public TextMeshPro score;
    public TextMeshPro finish;

    private void Start()
    {
        finish.enabled = false;
        Tracker.showObjective = true;
        StartCoroutine(StartGame());
    }

    IEnumerator StartGame()
    {
        while (ScoreKeeper.found < ObjectController.imageObjects.Length)
        {
            score.text = "Score: " + ScoreKeeper.found.ToString();
            if (Tracker.showObjective)
            {
                PlayerController.canMove = false;
                yield return StartCoroutine(ShowImageController.ShowImage());
                Tracker.showObjective = false;
                Tracker.find = true;
            }
            if (Tracker.find)
            {
                PlayerController.canMove = true;
                yield return StartCoroutine(ColliderOnObjective.Finding());
                Tracker.find = false;
                Tracker.showValidation = true;
            }
            if (Tracker.showValidation)
            {
             
                PlayerController.canMove = false;
                if (ImageSwitch.showOnConfirm)
                {
                    if (ScoreKeeper.success)
                    {
                        ScoreKeeper.found++;
                        yield return StartCoroutine(SuccessFailController.ShowSuccess());
                        Tracker.showValidation = false;
                        Tracker.showObjective = true;
                    }
                    else
                    {
                        yield return StartCoroutine(SuccessFailController.ShowFail());
                        Tracker.showValidation = false;
                        Tracker.find = true;

                    }
                    ImageSwitch.showOnConfirm = false;
                }
            }
            yield return null;
            //load end scene?
        }
        finish.enabled = true;
    }
}

