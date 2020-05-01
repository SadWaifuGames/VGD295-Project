using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public Button level02Button, level03Button, level04Button, level05Button, level06Button, level07Button, level08Button, level09Button;
    
    int levelPassed = 2;
    

    public GameObject grey2, grey3, grey4, grey5, grey6, grey7, grey8, grey9, lock2, lock3, lock4, lock5, lock6, lock7, lock8, lock9;

    // Start is called before the first frame update
    void Start()
    {
        levelPassed = PlayerPrefs.GetInt("LevelPassed");
        
        level02Button.interactable = false;
        level03Button.interactable = false;
        level04Button.interactable = false;
        level05Button.interactable = false;
        level06Button.interactable = false;
        level07Button.interactable = false;

        switch (levelPassed)
        {
            case 3:
                level02Button.interactable = true;
                grey2.SetActive(false);
                lock2.SetActive(false);
                break;
            case 4:
                level02Button.interactable = true;
                grey2.SetActive(false);
                lock2.SetActive(false);
                level03Button.interactable = true;
                grey3.SetActive(false);
                lock3.SetActive(false);
                break;
            case 5:
                level02Button.interactable = true;
                grey2.SetActive(false);
                lock2.SetActive(false);
                level03Button.interactable = true;
                grey3.SetActive(false);
                lock3.SetActive(false);
                level04Button.interactable = true;
                grey4.SetActive(false);
                lock4.SetActive(false);
                break;
            case 6:
                level02Button.interactable = true;
                grey2.SetActive(false);
                lock2.SetActive(false);
                level03Button.interactable = true;
                grey3.SetActive(false);
                lock3.SetActive(false);
                level04Button.interactable = true;
                grey4.SetActive(false);
                lock4.SetActive(false);
                level05Button.interactable = true;
                grey5.SetActive(false);
                lock5.SetActive(false);
                break;
            case 7:
                level02Button.interactable = true;
                grey2.SetActive(false);
                lock2.SetActive(false);
                level03Button.interactable = true;
                grey3.SetActive(false);
                lock3.SetActive(false);
                level04Button.interactable = true;
                grey4.SetActive(false);
                lock4.SetActive(false);
                level05Button.interactable = true;
                grey5.SetActive(false);
                lock5.SetActive(false);
                grey6.SetActive(false);
                lock6.SetActive(false);
                level06Button.interactable = true;
                break;
            case 8:
                level02Button.interactable = true;
                grey2.SetActive(false);
                lock2.SetActive(false);
                level03Button.interactable = true;
                grey3.SetActive(false);
                lock3.SetActive(false);
                level04Button.interactable = true;
                grey4.SetActive(false);
                lock4.SetActive(false);
                level05Button.interactable = true;
                grey5.SetActive(false);
                lock5.SetActive(false);
                grey6.SetActive(false);
                lock6.SetActive(false);
                grey7.SetActive(false);
                lock7.SetActive(false);
                level06Button.interactable = true;
                level07Button.interactable = true;
                break;
            case 9:
                level02Button.interactable = true;
                grey2.SetActive(false);
                lock2.SetActive(false);
                level03Button.interactable = true;
                grey3.SetActive(false);
                lock3.SetActive(false);
                level04Button.interactable = true;
                grey4.SetActive(false);
                lock4.SetActive(false);
                level05Button.interactable = true;
                grey5.SetActive(false);
                lock5.SetActive(false);
                grey6.SetActive(false);
                lock6.SetActive(false);
                grey7.SetActive(false);
                lock7.SetActive(false);
                grey8.SetActive(false);
                lock8.SetActive(false);
                level06Button.interactable = true;
                level07Button.interactable = true;
                level08Button.interactable = true;
                break;
            case 10:
                level02Button.interactable = true;
                grey2.SetActive(false);
                lock2.SetActive(false);
                level03Button.interactable = true;
                grey3.SetActive(false);
                lock3.SetActive(false);
                level04Button.interactable = true;
                grey4.SetActive(false);
                lock4.SetActive(false);
                level05Button.interactable = true;
                grey5.SetActive(false);
                lock5.SetActive(false);
                grey6.SetActive(false);
                lock6.SetActive(false);
                grey7.SetActive(false);
                lock7.SetActive(false);
                grey8.SetActive(false);
                lock8.SetActive(false);
                grey9.SetActive(false);
                lock9.SetActive(false);
                level06Button.interactable = true;
                level07Button.interactable = true;
                level08Button.interactable = true;
                level09Button.interactable = true;
                break;
                

        }

    }

    // Update is called once per frame
    public void levelToLoad (int level)
    {
        SceneManager.LoadScene(level);
    }

    public void loadTutorial()
    {
        SceneManager.LoadScene("tutorialBasiic");
    }

    public void resetPlayerPrefs()
    {
        level02Button.interactable = false;
        level03Button.interactable = false;
        level04Button.interactable = false;
        level05Button.interactable = false;
        level06Button.interactable = false;
        level07Button.interactable = false;
        PlayerPrefs.DeleteAll();
        
    }
}
