using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public GameObject SpawnPoint;
    private GameObject Player;
    private GameObject Blende;
    public GameObject cmOld;
    public GameObject cmNew;
    Animator BlendeAnimation;


    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Blende = GameObject.Find("Blende");
        BlendeAnimation = Blende.GetComponent<Animator>();

    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        
        Player.transform.position = SpawnPoint.transform.position;
        cmOld.SetActive(false);
        cmNew.SetActive(true);
        BlendeAnimation.SetBool("DoorClicked", true);

    }

    private void OnMouseUp()
    {

        BlendeAnimation.SetBool("DoorClicked", false);
    }
   
}