﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{

    Collider2D col;
    public GameObject bubble;
    public GameObject bubble2;
    public GameObject fish2;

    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider2D>();
        bubble.SetActive(true);
        bubble2.SetActive(false);
        fish2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)//we are touching the screen
        {
            Touch touch = Input.GetTouch(0);
            //where did that touch take place? (show me on this doll lmao)
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            if (touch.phase == TouchPhase.Began)
            {
                //tests if we just touched the screen
                //store the collider component of whatever we touched
                Collider2D touchedCollider = Physics2D.OverlapPoint(touchPosition);
                if (col == touchedCollider)
                {
                    bubble.SetActive(false);
                    bubble2.SetActive(true);
                    Invoke("HideBubble", 4f);
                }

            }
        }
    }

    void HideBubble()
    {
        bubble2.SetActive(false);
        fish2.SetActive(true);
    }
}
