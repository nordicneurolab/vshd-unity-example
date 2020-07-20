using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//controls the user feedback
public class SuccessFailController : MonoBehaviour
{
    static GameObject successImage, failImage;
   

    private void Start()
    {
        successImage = GameObject.FindGameObjectWithTag("Success");
        failImage = GameObject.FindGameObjectWithTag("Fail");
        successImage.GetComponent<SpriteRenderer>().enabled = false;
        failImage.GetComponent<SpriteRenderer>().enabled = false;
     

    }

    public static IEnumerator ShowSuccess()
    {
        ScoreKeeper.success = false;
        successImage.GetComponent<SpriteRenderer>().enabled = true;
        yield return new WaitForSeconds(3f);
        successImage.GetComponent<SpriteRenderer>().enabled = false;
    }
    public static IEnumerator ShowFail()
    {
        failImage.GetComponent<SpriteRenderer>().enabled = true;
        yield return new WaitForSeconds(3f);
        failImage.GetComponent<SpriteRenderer>().enabled = false;
    }
}
