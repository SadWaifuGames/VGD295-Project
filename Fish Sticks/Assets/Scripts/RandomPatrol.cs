using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomPatrol : MonoBehaviour
{

    //this script will be attached to any of the objects that will be moving around the screen
    //it allows them to randomly move about the screen within the boundaries of the map

    //variables to define the edges of the game play area
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    public float minSpeed;
    public float maxSpeed;
    //how fast the object moves
    float speed;

    //ramp up difficulty variable
    public float secondsToMaxDifficulty;

    //position the objects should move to
    Vector2 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        targetPosition = GetRandomPosition();
    }

    // Update is called once per frame
    void Update()
    {
        //checks position and moves the object towards it
        if ((Vector2)transform.position != targetPosition)
        {
            //set speed based on difficulty percentage
            speed = Mathf.Lerp(minSpeed, maxSpeed, GetDifficultyPercent());
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Fish")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    //calculates the percentage to max difficulty
    float GetDifficultyPercent()
    {
        //returns a float between 0 and 1
        return Mathf.Clamp01(Time.timeSinceLevelLoad / secondsToMaxDifficulty);
    }
}
