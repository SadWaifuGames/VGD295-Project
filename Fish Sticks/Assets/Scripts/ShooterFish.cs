using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterFish : MonoBehaviour
{

    public Transform shotPos;  //somewhere further away from the fish so the fish doesn't destroy itself with its own shot

    public GameObject projectile;

    private float timeBetweenShots;
    public float startTimeBetweenShots;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBetweenShots <= 0)
        {
            Instantiate(projectile, shotPos.position, Quaternion.identity);
            timeBetweenShots = startTimeBetweenShots;
        }
        else
        {
            timeBetweenShots -= Time.deltaTime;
        }
        
    }
}
