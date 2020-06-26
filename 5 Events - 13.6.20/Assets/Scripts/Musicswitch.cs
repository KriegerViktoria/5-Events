using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musicswitch : MonoBehaviour
{
    public bool outside;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        outside = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        outside = false;
    }
}
