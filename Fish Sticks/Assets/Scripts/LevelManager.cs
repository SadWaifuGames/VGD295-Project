using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
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
