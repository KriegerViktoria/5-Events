using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endgame : MonoBehaviour
{
    public GameObject Paused;
    public bool paused = false;
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Paused.SetActive(true);
            paused = true;
       }

        if (paused == true) 
        { 
            if (Input.GetKeyDown(KeyCode.Escape))
             {
            
                Application.Quit();
             }

            if (Input.GetMouseButtonDown(0))
            {
         
                Paused.SetActive(false);
                paused = false;
            }
        }
    }
}
