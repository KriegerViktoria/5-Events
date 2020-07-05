using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class lighton : MonoBehaviour
{
    public bool lighttoggle;
    Light2D lighty;
    void Start()
    {
     
        lighty = this.GetComponent<Light2D>();
    }

    private void Update()
    {
        if (lighttoggle == true)
        {
            lighty.enabled = true;
        }
    else
        {
            lighty.enabled = false;
        }
    }

}
