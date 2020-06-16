using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InteractDrop : MonoBehaviour, IDropHandler
{
    public GameObject ItemToInteractWith;
    public void OnDrop(PointerEventData eventData)
    {
       // Debug.Log("OnDrop");

        if (eventData.pointerDrag == ItemToInteractWith)
        {
            print("Sent Mail");
            eventData.pointerDrag.SetActive(false);
        }
        //eventData.pointerDrag
    }
}
