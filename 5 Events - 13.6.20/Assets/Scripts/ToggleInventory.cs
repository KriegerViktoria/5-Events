using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleInventory : MonoBehaviour
{
    public GameObject Inventory;
    bool firstClick;
    RectTransform rectTransform;
    public UnityEngine.Vector3 ToggleOffScreen;
    public UnityEngine.Vector3 ToggleOnScreen;

    // Start is called before the first frame update
    private void Awake()
    {
        firstClick = true;
        rectTransform = GetComponent<RectTransform>();
    }
    public void Toggle ()
    {
        if(firstClick)
        {
            //  Inventory.GetComponent<RectTransform>().anchoredPosition.y 
           // Inventory.GetComponent<RectTransform>().anchoredPosition.y = new Vector2(0, 609);
            firstClick = false;
        }
       else
        {
            Inventory.transform.position = ToggleOnScreen;
            firstClick = true;
        }
    }
}
