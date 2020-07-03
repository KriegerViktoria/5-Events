using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepTrail : MonoBehaviour
{
    public ParticleSystem trail;
    public GameObject player;
     PointandClickScript script;
    private void Awake()
    {
        script = player.GetComponent<PointandClickScript>();
    }


    private void Update()
    {

        if (script.isMoving == true)
        {
            trail.enableEmission = true;
        }


        if (script.isMoving == false)
        {
            trail.enableEmission = false;
        }
    }

}
