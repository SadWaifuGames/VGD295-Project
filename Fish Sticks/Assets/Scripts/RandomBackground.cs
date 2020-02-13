using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBackground : MonoBehaviour
{
    //this script will choose a random background image for a scene
    private int rand;
    public Sprite[] backgroundSprites;
    // Start is called before the first frame update
    void Start()
    {
        rand = Random.Range(0, backgroundSprites.Length);
        GetComponent<SpriteRenderer>().sprite = backgroundSprites[rand];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
