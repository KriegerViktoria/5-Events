using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveClouds : MonoBehaviour
{
    [Range(0.0f, 0.02f)]
    public float speed;
    public Vector3 Endposition;
    public Vector3 Spawnposition;

    private void FixedUpdate()
    {
        this.gameObject.transform.position += Vector3.left * speed;
        if (this.gameObject.transform.position.x < Endposition.x)
        {
            this.gameObject.transform.position = Spawnposition;
        }

    }
}
