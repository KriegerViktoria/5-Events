﻿using System;
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
    public GameObject test;


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
        Player.GetComponent<PointandClickScript>().isMoving = false;
        Player.GetComponent<Animator>().SetBool("Walk", false);
        Player.transform.position = SpawnPoint.transform.position;
        cmOld.SetActive(false);
        cmNew.SetActive(true);
        BlendeAnimation.SetBool("DoorClicked", true);
        test.GetComponent<dontwalk>().On = false;
        
    }

    private void OnMouseUp()
    {

        BlendeAnimation.SetBool("DoorClicked", false);
        test.GetComponent<dontwalk>().On = true;
    }
   
}