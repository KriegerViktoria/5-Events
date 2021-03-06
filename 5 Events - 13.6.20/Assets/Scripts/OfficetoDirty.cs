﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfficetoDirty : MonoBehaviour
{
    public GameObject trash;
    public GameObject broom;
    public GameObject stuhl;
    public GameObject kiste;
    public GameObject book;
    public GameObject newbackground;
    public GameObject oldbackground;
    public GameObject trashlight;
    public GameObject combination;
    public Pickup pickup;
    public Pickup pickup2;
    public Pickup pickup3;
    public GameObject messytext;
    public Pickup pickup4;
    public GameObject boylifttext;
    public lighton light1, light2, light3, light4, light5;

    // Start is called before the first frame update
    public void MakeDirty()
    {
        GameObject.Find("/__________WRS UI__________/Canvas/-----CROPS_TRIGGER/ThickBookPlace").SetActive(true);
        GameObject.Find("/__________WRS UI__________/Canvas/-----CROPS_TRIGGER/LaundryBasketPlace").SetActive(true);
        GameObject.Find("/__________WRS UI__________/Canvas/-----CROPS_TRIGGER/ChairPlace").SetActive(true);
        GameObject.Find("/__________INTERACTFG__________/Canvas/Trashcan").SetActive(true);
        GameObject.Find("/__________WRS UI__________/Canvas/-----CROPS_TRIGGER/Dirt").SetActive(true);
        GameObject.Find("/__________WRS UI__________/Canvas/-----CROPS_TRIGGER/ReactionTrigger").SetActive(true);
        GameObject.Find("/__________Collectibles_______/ErsteHilfeSet").SetActive(false);
        combination.SetActive(false);
        trash.SetActive(true);
        book.SetActive(true);
        kiste.SetActive(true);
        stuhl.SetActive(true);
        broom.GetComponent<Pickup>().isNeeded = true;
        newbackground.SetActive(true);
        oldbackground.SetActive(false);
        trashlight.SetActive(true);
        pickup.isNeeded = true;
        pickup2.isNeeded = true;
        pickup3.isNeeded = true;
        pickup3.isNeeded = true;
        messytext.SetActive(true);
        boylifttext.SetActive(false);
        light1.lighttoggle = true;
        light2.lighttoggle = true;
        light3.lighttoggle = true;
        light4.lighttoggle = true;
        light5.lighttoggle = true;

    }
}
