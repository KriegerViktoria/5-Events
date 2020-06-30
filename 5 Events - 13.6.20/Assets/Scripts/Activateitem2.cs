using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activateitem2 : MonoBehaviour
{
    public GameObject Item1;
    public GameObject Item2;
    public GameObject Item3;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Item1.GetComponent<Pickup>().isNeeded = true;
        Item2.GetComponent<Pickup>().isNeeded = true;
        Item3.GetComponent<Pickup>().isNeeded = true;
    }
}
