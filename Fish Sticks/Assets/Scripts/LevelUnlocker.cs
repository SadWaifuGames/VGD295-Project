using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUnlocker : MonoBehaviour
{
    public int level;
    public int starCount;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;

    private void Awake()
    {
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (level >= 2)
        {
            button2.SetActive(true);

        }
        if (level >= 3)
        {
            button3.SetActive(true);

        }
        if (level >= 4)
        {
            button4.SetActive(true);

        }
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        level = data.level;
        starCount = data.stars;
        
    }
}
