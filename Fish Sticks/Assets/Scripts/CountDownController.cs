using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownController : MonoBehaviour
{
    //this script controls a countdown timer for the start of each new level
    //it changes the countdown text in the beginning of each level to 3, 2, 1, Go! after 2 seconds
    public int countdownTime;
    public Text countdownDisplay;
    public GameObject fishContainer;
    public GameObject player;

    public void Start()
    {
        fishContainer.SetActive(false);
        player.SetActive(false);
        StartCoroutine(CountdownToStart());
    }

    IEnumerator CountdownToStart()
    {
        while (countdownTime > 0)
        {
            countdownDisplay.text = countdownTime.ToString();

            yield return new WaitForSeconds(1.2f);
            countdownTime--;
        }

        countdownDisplay.text = "Go!";
        player.SetActive(true);
        yield return new WaitForSeconds(1f);
        countdownDisplay.gameObject.SetActive(false);
        fishContainer.SetActive(true);
        
    }
}
