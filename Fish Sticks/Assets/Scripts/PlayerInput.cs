using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    bool moveAllowed;
    
    
    private bool isDead = false;

    //particle effects
    //particle when touched
    public GameObject selectionEffect;
    //particle when die
    public GameObject deathEffect;

    private AudioSource source;

    public AudioClip[] audioClips;

    // Start is called before the first frame update

    private void Awake()
    {
        
    }
    void Start()
    {
        
        
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead)
            return;
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
                if (touchedCollider.gameObject.tag == "Fish")
                {
                    source.clip = audioClips[Random.Range(0, audioClips.Length)];
                    source.Play();
                    Instantiate(selectionEffect, transform.position, Quaternion.identity);
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
}
