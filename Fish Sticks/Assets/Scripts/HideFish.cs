using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideFish : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] fish;
    // Start is called before the first frame update
    void Start()
    {
        
        foreach (GameObject fish in fish)
        {
            fish.SetActive(false);
        }
    }
}
