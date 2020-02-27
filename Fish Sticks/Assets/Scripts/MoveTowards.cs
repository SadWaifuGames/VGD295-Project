using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour
{
    //attach this script to a fish that you want to move towards or follow another fish on the screen

    public Transform otherFish;

    public float speed;
    Collider2D col;
    private GameMaster gm;
    private bool isDead = false;

    //particle effects
    //particle when touched
    public GameObject selectionEffect;
    //particle when die
    public GameObject deathEffect;

    public GameObject background;


    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        col = GetComponent<Collider2D>();
    }
    // Update is called once per frame
    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, otherFish.position, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Fish")
        {

            gm.GameOver();
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            background.SetActive(false);
            this.enabled = false;

        }

    }
}
