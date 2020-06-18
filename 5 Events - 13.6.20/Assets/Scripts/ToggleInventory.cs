using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleInventory : MonoBehaviour
{
    public GameObject inventory;
    bool firstClick;
    public UnityEngine.Vector3 ToggleOffScreen;
    public UnityEngine.Vector3 ToggleOnScreen;
    //public GameObject test;

    // Start is called before the first frame update
    private void Awake()
    {
      
        firstClick = true;
    }
    public void Toggle ()
    {
        if(firstClick)
        {
            inventory.transform.position = ToggleOffScreen;
            // Inventory.GetComponent<RectTransform>().anchoredPosition.y = new Vector2(0, 609);
            // inventory.transform.position = inventory.transform.position + (0,10,0);
            firstClick = false;

        }
       else
        {
            inventory.transform.position = ToggleOnScreen;
            firstClick = true;
        }
    }
}
