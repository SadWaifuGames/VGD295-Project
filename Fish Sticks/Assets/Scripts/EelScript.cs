using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EelScript : MonoBehaviour
{

    bool moveAllowed;

    Collider2D col;

    public GameObject zapSprite;

    float randomThreshold;
    float minThreshold = 2.0f;
    float maxThreshold = 10.0f;
    float timer;
    bool isZapping;

    int randomZapping;
    int minZap = 3;
    int maxZap = 10;

    float timeBetweenZaps = 1f;
    
    


    // Start is called before the first frame update
    void Start()
    {
        randomThreshold = UnityEngine.Random.Range(minThreshold, maxThreshold);
        randomZapping = UnityEngine.Random.Range(minZap, maxZap);
        zapSprite.SetActive(false);
        col = GetComponent<Collider2D>();
        StartCoroutine(ZappingEel());
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isZapping == false)
        {
            timer += Time.deltaTime;
        }

        if(timer > randomThreshold)
        {
            timer = 0.0f;
            ZappingEel();
        }
    }

    IEnumerator ZappingEel()
    {
        isZapping = true;
        for (int i = 0; i < randomZapping; i++)
        {
            zapSprite.SetActive(false);
            yield return new WaitForSeconds(timeBetweenZaps);
            zapSprite.SetActive(true);
            yield return new WaitForSeconds(timeBetweenZaps);
        }

        randomThreshold = UnityEngine.Random.Range(minThreshold, maxThreshold);
        randomZapping = UnityEngine.Random.Range(minZap, maxZap);
        isZapping = false;
    }

    
}
