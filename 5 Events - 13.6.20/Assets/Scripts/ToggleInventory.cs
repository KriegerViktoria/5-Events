﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleInventory : MonoBehaviour
{
    public GameObject inventory;
    bool firstClick;
    public Vector2 ToggleOffScreen;
    public Vector2 ToggleOnScreen;
    //public GameObject test;

    // Start is called before the first frame update
    private void Awake()
    {
      
        firstClick = true;
    }
    public void Toggle (RectTransform ToBeMoved)
    {
        if(firstClick)
        {
           // inventory.transform.position = ToggleOffScreen;
            ToBeMoved.anchoredPosition = ToggleOffScreen;
            this.GetComponent<RectTransform>().Rotate(new Vector3(0, 0, 180));
            // inventory.transform.position = inventory.transform.position + (0,10,0);
            //firstClick = false;

        }
       else
        {
            //RectTransform
            ToBeMoved.anchoredPosition = ToggleOnScreen;
            this.GetComponent<RectTransform>().Rotate(new Vector3(0, 0, 180));
            //firstClick = true;
        }
        firstClick = !firstClick;
    }
}
