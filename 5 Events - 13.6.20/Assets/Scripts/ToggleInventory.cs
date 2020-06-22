using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleInventory : MonoBehaviour
{
    public GameObject inventory;
    bool firstClick;
    public Vector3 ToggleOffScreen;
    public Vector3 ToggleOnScreen;
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
            ToBeMoved.anchoredPosition = new Vector2(0, 609);
            // inventory.transform.position = inventory.transform.position + (0,10,0);
            //firstClick = false;

        }
       else
        {
            //RectTransform
            ToBeMoved.anchoredPosition = ToggleOnScreen;
            //firstClick = true;
        }
        firstClick = !firstClick;
    }
}
