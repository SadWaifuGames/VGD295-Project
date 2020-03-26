using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trophy : MonoBehaviour
{

    public GameObject[] fish;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D collision)
    {
        Player.instance.YouWin();
        Debug.Log("you have won");
        foreach (GameObject fish in fish)
        {
            fish.SetActive(false);
        }
    }
}
