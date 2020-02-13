using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowFish : MonoBehaviour
{
    //ADD THIS SCRIPT TO ANY FISH YOU WANT TO GROW WHEN TOUCHED
    //this script detects if we are allowed to drag the fish or not and detect collisions between fish
    //variables
    bool moveAllowed;
    Collider2D col;
    Vector2 temp;
    public float sizeIncrease = .1f;

    private GameMaster gm;

    public GameObject madSprite;

    private AudioSource source;

    public AudioClip[] audioClips;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        //gets collider attached to fish
        col = GetComponent<Collider2D>();
        //gets the starting size of the fish
        temp = transform.localScale;
        source = GetComponent<AudioSource>();
        madSprite.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //tracking if there is a finger touching the screen
        //touchCount uses a 0,1,2 index to determine how many fingers are touching the screen
        //we only want to let the player move one fish at a time using only one finger so we will pass in 0
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
                    source.clip = audioClips[Random.Range(0, audioClips.Length)];
                    source.Play();
                    //we touched a fish with this script on it
                    moveAllowed = true;

                }
            }

            if (touch.phase == TouchPhase.Moved)
            {
                //tests if we just moved the finger on the screen
                if (moveAllowed)
                {
                    //if we touched a fish we can move, this sets a new position based on where the finger swiped
                    transform.position = new Vector2(touchPosition.x, touchPosition.y);
                    //increases the scale of the fish 
                    temp.x += sizeIncrease;
                    temp.y += sizeIncrease;
                    transform.localScale = new Vector2(temp.x, temp.y);
                }
            }

            if (touch.phase == TouchPhase.Ended)
            {
                //tests if we took finger off the screen
                //if finger off the screen, reset move allowed to false
                moveAllowed = false;
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Fish")
        {
            gm.GameOver();
            madSprite.SetActive(true);
        }
    }
}
