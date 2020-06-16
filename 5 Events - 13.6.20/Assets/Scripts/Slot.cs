using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour {


    private Inventory inventory;
    public int index;

    private void Start()
    {
        
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void Update()
    {
        if (transform.childCount == 1) {
            inventory.items[index] = 0;
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("InventoryDrop");
           
    }
        //eventData.pointerDrag
    }


