using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public string[] winnerTexts =
    {
        "Great Job!",
        "Way to Go!",
        "Awesome Sauce!",
        "Cool Beans!",
        "Super Duper!",
    };

    public static Player instance = null;
    public Text winText;

    int sceneIndex;
    int levelPassed = 1;

    public GameObject deathScreen;
    public GameObject trophy;
    public GameObject winScreen;

    public Text scoreText;
    private bool hasLost;
    public float score = 0.0f;
    public float difficultyScore;

    void Start()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (levelPassed >= 2)
        {
            levelPassed = PlayerPrefs.GetInt("LevelPassed");
        }
        //levelPassed = PlayerPrefs.GetInt("LevelPassed");
        deathScreen.SetActive(false);

        winScreen.SetActive(false);
        trophy.SetActive(false);

        string myString = winnerTexts[Random.Range(0, winnerTexts.Length)];
        winText.text = myString;

    }

    public void Update()
    {

        if (hasLost == false)
        {
            score += Time.deltaTime * 2f;
            scoreText.text = ("Score: " + (int)score).ToString();

            
            if (score >= difficultyScore)
            {
                trophy.SetActive(true);

            }
        }



    }
    
    public void YouWin()
    {
        if (levelPassed < sceneIndex)
        {
            
            PlayerPrefs.SetInt("LevelPassed", sceneIndex);
            winScreen.SetActive(true);
            Invoke("loadNextLevel", 1f);
            hasLost = true;
            Debug.Log("the scene index is " + sceneIndex);
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

    void loadNextLevel ()
    {
        SceneManager.LoadScene(sceneIndex + 1);
    }
}
