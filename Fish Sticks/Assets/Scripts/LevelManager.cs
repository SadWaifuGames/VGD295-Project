﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    private PlayerData player;

    // Start is called before the first frame update
    public void GoToGameScene()
    {
        SceneManager.LoadScene("LevelMenu");
        SaveSystem.SavePlayer(player);
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
        SceneManager.LoadScene("level2.1");
    }

    public void LoadSceneThree()
    {
        SceneManager.LoadScene("Level1.3");
    }

    public void LoadShop()
    {
        SceneManager.LoadScene("Shop");
    }

    public void LoadLibrary()
    {
        SceneManager.LoadScene("Library");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
