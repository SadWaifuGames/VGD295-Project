using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LibraryFish : MonoBehaviour
{
    //Attach this script to fish in the library, will toggle on and off the info panels

    public GameObject panel;
    

   

    // Start is called before the first frame update
    void Start()
    {
       panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void PanelOn()
    {
        
        panel.SetActive(true);
       
    }

    public void PanelOff()
    {

        panel.SetActive(false);

    }
}
