using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Experimental.Rendering.LWRP;

public class InteractDrop : MonoBehaviour, IDropHandler
{
    public GameObject ItemToInteractWith;
    private GameObject objects;
    GameObject DoorToOffice;
    public GameObject influence;
    public GameObject script;
 

    private void Awake()
    {
        objects = GameObject.Find("__________CAM UI__________/Canvas/Objects");
        DoorToOffice = GameObject.Find("/__________WRS UI__________/Canvas/-----DOORS/Door_Floor2_to_Office");
    }
    public void OnDrop(PointerEventData eventData)
    {
        // Debug.Log("OnDrop");

        if (eventData.pointerDrag == ItemToInteractWith && this.gameObject == GameObject.Find("/__________WRS UI__________/Canvas/----- INTERACTABLES/-----FOREST/Mailbox"))
        {
            print("Sent Mail");
            eventData.pointerDrag.SetActive(false);
            eventData.pointerDrag.transform.SetParent(objects.transform);
            this.gameObject.SetActive(false);
            eventData.pointerDrag.GetComponent<DialogueTrigger>().TriggerDialogue();
        }

            if (eventData.pointerDrag == ItemToInteractWith && this.gameObject == GameObject.Find("/__________WRS UI__________/Canvas/-----CROPS_TRIGGER/BuildLadder"))
        {
            this.gameObject.SetActive(false);
            GameObject.Find("/__________WRS UI__________/Canvas/-----CROPS_TRIGGER/BuildLadder2").SetActive(true);
            influence.GetComponent<Pickup>().isNeeded = false;
        }

        if (eventData.pointerDrag == ItemToInteractWith && this.gameObject == GameObject.Find("/__________WRS UI__________/Canvas/-----CROPS_TRIGGER/BuildLadder2"))
        {
            this.gameObject.SetActive(false);
            GameObject.Find("/__________WRS UI__________/Canvas/-----CROPS_TRIGGER/BuildLadder3").SetActive(true);
            influence.GetComponent<Pickup>().isNeeded = false;
        }

        if (eventData.pointerDrag == ItemToInteractWith && this.gameObject == GameObject.Find("/__________WRS UI__________/Canvas/-----CROPS_TRIGGER/BuildLadder3"))
        {
            GameObject.Find("/__________WRS UI__________/Canvas/-----CROPS_TRIGGER/Cutscene7Trigger").SetActive(true);
            this.gameObject.SetActive(false);
            // this.gameObject.GetComponent<OfficetoDirty>().MakeDirty();
            //Start Cutscene with boy climbing the ladder and falling

        }

        if (eventData.pointerDrag == ItemToInteractWith && this.gameObject == GameObject.Find("/__________WRS UI__________/Canvas/-----CROPS_TRIGGER/ThickBookPlace"))
        {
            this.gameObject.SetActive(false);
            influence.GetComponent<CleanUpReaction>().bookBack = true;
        }

        if (eventData.pointerDrag == ItemToInteractWith && this.gameObject == GameObject.Find("/__________WRS UI__________/Canvas/-----CROPS_TRIGGER/ChairPlace"))
        {
            this.gameObject.SetActive(false);
            influence.GetComponent<CleanUpReaction>().chairBack = true;
        }

        if (eventData.pointerDrag == ItemToInteractWith && this.gameObject == GameObject.Find("/__________WRS UI__________/Canvas/-----CROPS_TRIGGER/LaundryBasketPlace"))
        {
            this.gameObject.SetActive(false);
            influence.GetComponent<CleanUpReaction>().basketback = true;
        }

        if (eventData.pointerDrag == ItemToInteractWith && this.gameObject == GameObject.Find("/__________WRS UI__________/Canvas/-----CROPS_TRIGGER/Dirt"))
        {
            this.gameObject.SetActive(false);
            print("cleaned");
            influence.GetComponent<CleanUpReaction>().cleaned2 = true;
            GameObject.Find("/__________WRS UI__________/Canvas/-----CROPS_TRIGGER/BroomPlace").SetActive(true);
        }

        if (eventData.pointerDrag == ItemToInteractWith && this.gameObject == GameObject.Find("/__________WRS UI__________/Canvas/-----CROPS_TRIGGER/Trashcan"))
        {
            this.gameObject.SetActive(false);
            influence.GetComponent<CleanUpReaction>().cleaned3 = true;
            eventData.pointerDrag.SetActive(false);
            eventData.pointerDrag.transform.SetParent(objects.transform);
        }

        if (eventData.pointerDrag == ItemToInteractWith && this.gameObject == GameObject.Find("/__________WRS UI__________/Canvas/----- INTERACTABLES/-----DADROOM/Trashcan"))
        {
            print("trashed");
            eventData.pointerDrag.SetActive(false);
            eventData.pointerDrag.transform.SetParent(objects.transform);
        }
    }
}
