using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{
    public GameObject loseScreen;
    public GameObject oneStar;
    public GameObject twoStar;
    public GameObject threeStar;


    public Text score;
    private bool hasLost;
    public float playerScore;
    string playerScoreString;
    public int starCount;
    public int levelCount;

    void Awake ()
    {
        playerScore = 0.0f;
        starCount = 0;
        oneStar.SetActive(false);
        twoStar.SetActive(false);
        threeStar.SetActive(false);
    }
      
    private void Update()
    {
        
        if (hasLost == false)
        {
           playerScore = Time.time * 4f;
           playerScoreString = playerScore.ToString("F0");
           score.text = "Score:  " + playerScoreString;

           if (playerScore >= 50f)
            {
                oneStar.SetActive(true);
                starCount++;
            }
            if (playerScore >= 100f)
            {
                twoStar.SetActive(true);
                starCount++;
                levelCount++;
            }
            if (playerScore >= 150f)
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
        loseScreen.SetActive(true);
    }

    public void GoToGameScene()
    {
        SceneManager.LoadScene("LevelMenu");
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("LevelMenu");
    }

    public void LoadSceneOne()
    {
        SceneManager.LoadScene("Level1.1");
    }

    public void LoadSceneTwo()
    {
        SceneManager.LoadScene("Level1.2");
    }

    public void LoadSceneThree()
    {
        SceneManager.LoadScene("Level1.3");
    }
    
}
