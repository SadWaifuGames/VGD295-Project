﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BasicTutorial : MonoBehaviour
{
    public GameObject firstFish, secondFish, thirdFish, fourthFish, fifthFish, trophy;
    public Text textOne, textTwo, textThree, textFour, textFive;
    public Button btnOne, btnTwo, btnThree, btnFour;    

    // Start is called before the first frame update
    void Start()
    {
        firstFish.SetActive(true);
        secondFish.SetActive(false);
        thirdFish.SetActive(false);
        fourthFish.SetActive(false);
        fifthFish.SetActive(false);
        trophy.SetActive(false);
        textOne.gameObject.SetActive(true);
        textTwo.gameObject.SetActive(false);
        textThree.gameObject.SetActive(false);
        textFour.gameObject.SetActive(false);
        textFive.gameObject.SetActive(false);
        btnOne.gameObject.SetActive(true);
        btnTwo.gameObject.SetActive(false);
        btnThree.gameObject.SetActive(false);
        btnFour.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonOne ()
    {
        firstFish.SetActive(false);
        secondFish.SetActive(true);
        thirdFish.SetActive(true);
        textOne.gameObject.SetActive(false);
        textTwo.gameObject.SetActive(true);
        btnOne.gameObject.SetActive(false);
        btnTwo.gameObject.SetActive(true);
    }

    public void ButtonTwo()
    {
        
        secondFish.SetActive(false);
        thirdFish.SetActive(false);
        fourthFish.SetActive(true);
        fifthFish.SetActive(true);
        textTwo.gameObject.SetActive(false);
        textThree.gameObject.SetActive(true);
        Invoke("ShowX", 2f);
        btnTwo.gameObject.SetActive(false);
        btnThree.gameObject.SetActive(true);
    }

    void ShowX()
    {
        textFour.gameObject.SetActive(true);
    }

    public void ButtonThree()
    {

        fourthFish.SetActive(false);
        fifthFish.SetActive(false);
        trophy.gameObject.SetActive(true);
        firstFish.SetActive(true);
        textThree.gameObject.SetActive(false);
        textFour.gameObject.SetActive(false);
        textFive.gameObject.SetActive(true);
        btnThree.gameObject.SetActive(false);
        btnFour.gameObject.SetActive(true);
    }

    public void ButtonFour()
    {
        SceneManager.LoadScene("LevelMenu");
    }

}
