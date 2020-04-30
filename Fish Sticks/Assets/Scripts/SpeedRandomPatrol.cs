using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedRandomPatrol : MonoBehaviour
{
    //ADD TO A FISH THAT YOU WANT TO SPEED UP ONLY WHEN TOUCHED AND NOT OVER TIME LIKE A NORMAL FISH
    //BE SURE TO ADD THE SPEED FISH SCRIPT TOO
    //this script will be attached to any of the objects that will be moving around the screen
    //it allows them to randomly move about the screen within the boundaries of the map

    //variables to define the edges of the game play area
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    public static float speed;

        

    //position the objects should move to
    Vector2 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        targetPosition = GetRandomPosition();
        speed = 1f;
        
    }

    // Update is called once per frame
    void Update()
    {
        //speed = speed;
        //checks position and moves the object towards it
        if ((Vector2)transform.position != targetPosition)
        {
                       
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }
        else
        {
            targetPosition = GetRandomPosition();
        }
    }

    //function that gets a rondom position for the fish to go to
    Vector2 GetRandomPosition()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        //return the new Vector stored for X and Y
        return new Vector2(randomX, randomY);
    }

    //detect if the fishes have collided
    
}
