using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InteractDrop : MonoBehaviour, IDropHandler
{
    public GameObject ItemToInteractWith;
    private GameObject objects;
    private void Awake()
    {
        objects = GameObject.Find("__________CAM UI__________/Canvas/Objects");
    }
    public void OnDrop(PointerEventData eventData)
    {
        // Debug.Log("OnDrop");

        if (eventData.pointerDrag == ItemToInteractWith || this.gameObject == GameObject.Find("/__________WRS UI__________/Canvas/----- INTERACTABLES/-----FOREST/Mailbox"))
        {
            print("Sent Mail");
            eventData.pointerDrag.SetActive(false);
            eventData.pointerDrag.transform.SetParent(objects.transform);
        }

     //   if (eventData.pointerDrag == ItemToInteractWith || this.gameObject == GameObject.Find("/__________WRS UI__________/Canvas/----- INTERACTABLES/-----FOREST/________"))
     //   {
     //       print("Sent Mail");
     //       eventData.pointerDrag.SetActive(false);
     //       eventData.pointerDrag.transform.SetParent(objects.transform);
     //   }
       
    }
}
