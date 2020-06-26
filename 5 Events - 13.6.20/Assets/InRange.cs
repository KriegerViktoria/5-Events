using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InRange : MonoBehaviour
{
    public GameObject Spawn;
    public bool inrange;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("ActiveSpawn");
        inrange = true;
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        print("DeactivateSpawn");
        inrange = false;
    }

}
