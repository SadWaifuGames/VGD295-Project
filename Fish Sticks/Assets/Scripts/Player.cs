using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int level = 1;
    public int starCount = 0;

    public GameObject deathScreen;
    public GameObject oneStar;
    public GameObject twoStar;
    public GameObject threeStar;

    public Text scoreText;
    private bool hasLost;
    public float score = 0.0f;

    void Start()
    {
        

        starCount = 0;
        oneStar.SetActive(false);
        twoStar.SetActive(false);
        threeStar.SetActive(false);
        deathScreen.SetActive(false);
    }

    public void Update()
    {

        if (hasLost == false)
        {
            score += Time.deltaTime * 4f;
            scoreText.text = ("Score: " + (int)score).ToString();

            if (score >= 50f)
            {
                oneStar.SetActive(true);
                starCount++;
            }
            if (score >= 100f)
            {
                twoStar.SetActive(true);
                starCount++;
                level++;
            }
            if (score >= 150f)
            {
                threeStar.SetActive(true);
                starCount++;
            }
        }



    }

    public void GameOver()
    {
        hasLost = true;
        Invoke("Delay", 1.5f);
        

    }

    void Delay()
    {
        deathScreen.SetActive(true);
    }
}
