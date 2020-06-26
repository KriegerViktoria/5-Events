using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontwalk : MonoBehaviour
{
    public GameObject player;
    public Vector3 playerpos;
    public bool On;

    private void Awake()
    {
        On = true;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (On)
        {
            playerpos = collision.transform.position;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (On)
        {
            player.GetComponent<PointandClickScript>().isMoving = false;
            player.GetComponent<Animator>().SetBool("Walk", false);
            player.transform.position = playerpos;
        }    
        }
}


