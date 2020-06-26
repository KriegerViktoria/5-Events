using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class block : MonoBehaviour
{
    public Vector3 playerpos;
    public GameObject room;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("god fucking damn it");
        playerpos = room.GetComponent<dontwalk>().playerpos;
        player.transform.position = playerpos;
        player.GetComponent<Animator>().SetBool("Walk", false);
        player.GetComponent<PointandClickScript>().isMoving = false;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        playerpos = room.GetComponent<dontwalk>().playerpos;
        player.transform.position = playerpos;
        player.GetComponent<Animator>().SetBool("Walk", false);
        player.GetComponent<PointandClickScript>().isMoving = false;
    }
}

