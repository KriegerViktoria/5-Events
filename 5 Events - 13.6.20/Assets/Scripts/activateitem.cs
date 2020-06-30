using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateitem : MonoBehaviour
{
    public GameObject Item1;
    public GameObject Item2;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Item1.GetComponent<Pickup>().isNeeded = true;
        Item2.GetComponent<Pickup>().isNeeded = true;
    }
}
