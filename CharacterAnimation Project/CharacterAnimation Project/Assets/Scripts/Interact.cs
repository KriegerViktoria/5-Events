using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public Item currentObject;
    public GameObject InteractWith;
    

    public void Interaction(Item InventoryItem)
    {
        currentObject = InventoryItem;
       // if (Input.GetMouseButtonDown(0))
    }

    
}
    