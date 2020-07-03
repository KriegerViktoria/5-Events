using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Door : MonoBehaviour { 
    public GameObject SpawnPoint;
    private GameObject Player;
    public GameObject Blende;
    public GameObject cmOld;
    public GameObject cmNew;
    Animator BlendeAnimation;
    public GameObject room;
 


    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        BlendeAnimation = Blende.GetComponent<Animator>();
   
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Player.GetComponent<PointandClickScript>().isMoving = false;
            Player.GetComponent<Animator>().SetBool("Walk", false);
            Player.transform.position = SpawnPoint.transform.position;
            cmOld.SetActive(false);
            cmNew.SetActive(true);
            BlendeAnimation.SetBool("DoorClicked", true);
            room.GetComponent<dontwalk>().On = false;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            BlendeAnimation.SetBool("DoorClicked", false);
            room.GetComponent<dontwalk>().On = true;
        }
    }


    // Update is called once per frame
   // private void OnMouseDown()
 // 
 // {
 //       if (InRange) { 
 //     Player.GetComponent<PointandClickScript>().isMoving = false;
 //     Player.GetComponent<Animator>().SetBool("Walk", false);
 //     Player.transform.position = SpawnPoint.transform.position;
 //     cmOld.SetActive(false);
 //     cmNew.SetActive(true);
 //     BlendeAnimation.SetBool("DoorClicked", true);
 //     test.GetComponent<dontwalk>().On = false;
 //       }
 //   }
 //
 //   private void OnMouseUp()
 //   {
 //
 //       BlendeAnimation.SetBool("DoorClicked", false);
 //       test.GetComponent<dontwalk>().On = true;
 //   }
 //
   

}