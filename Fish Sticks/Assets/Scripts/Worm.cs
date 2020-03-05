using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Worm : MonoBehaviour
{
    public AudioSource[] sounds;
    public AudioSource sound1;
    public AudioSource sound2;

    private Player player;
    Collider2D col;
    public GameObject worm;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        col = GetComponent<Collider2D>();
        sounds = GetComponents<AudioSource>();
        sound1 = sounds[0];
        sound2 = sounds[1];
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Fish")
        {

            sound2.Play();
            player.score -= 100f;

            worm.SetActive(false);

        }
    }
}
