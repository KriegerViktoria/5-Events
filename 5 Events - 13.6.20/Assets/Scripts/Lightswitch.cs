using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightswitch : MonoBehaviour
{
    public GameObject Light;
    public Pickup LightedObject;

    private void Update()
    {
        if (LightedObject.isNeeded)
        {
           
            Light.SetActive(true);
            
        }
        else
        {
            Light.SetActive(false);
        }
    }
}
