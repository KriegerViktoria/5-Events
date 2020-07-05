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
    public GameObject influence2;
    public GameObject influence3;
    public lighton Light;
    public lighton Light2;

    private void Awake()
    {
        objects = GameObject.Find("__________CAM UI__________/Canvas/Objects");
        DoorToOffice = GameObject.Find("/__________WRS UI__________/Canvas/-----DOORS/Door_Floor2_to_Office");
    }
    public void OnDrop(PointerEventData eventData)
    {
        print("onDrop");
        
        // Debug.Log("OnDrop");

        if (eventData.pointerDrag == ItemToInteractWith && this.gameObject == GameObject.Find("/__________WRS UI__________/Canvas/----- INTERACTABLES/-----FOREST/Mailbox"))
        {
            print("Sent Mail");
            eventData.pointerDrag.SetActive(false);
            eventData.pointerDrag.transform.SetParent(objects.transform);
            this.gameObject.SetActive(false);
            influence.GetComponent<DialogueTrigger>().TriggerDialogue();
            eventData.pointerDrag.GetComponent<DragDrop>().showdescription = false;
            Light.lighttoggle = false;
        }

            if (eventData.pointerDrag == ItemToInteractWith && this.gameObject == GameObject.Find("/__________WRS UI__________/Canvas/-----CROPS_TRIGGER/BuildLadder"))
        {
            this.gameObject.SetActive(false);
            GameObject.Find("/__________WRS UI__________/Canvas/-----CROPS_TRIGGER/Cutscene7Trigger").SetActive(true);
            influence.SetActive(true);
            eventData.pointerDrag.SetActive(false);
            eventData.pointerDrag.transform.SetParent(objects.transform);
            eventData.pointerDrag.GetComponent<DragDrop>().showdescription = false;
            Light.lighttoggle = false;

            // influence.GetComponent<Pickup>().isNeeded = false;
        }

    //    if (eventData.pointerDrag == ItemToInteractWith && this.gameObject == GameObject.Find("/__________WRS UI__________/Canvas/-----CROPS_TRIGGER/BuildLadder2"))
    //    {
    //        this.gameObject.SetActive(false);
    //        GameObject.Find("/__________WRS UI__________/Canvas/-----CROPS_TRIGGER/BuildLadder3").SetActive(true);
    //        influence.GetComponent<Pickup>().isNeeded = false;
    //    }
    //
    //    if (eventData.pointerDrag == ItemToInteractWith && this.gameObject == GameObject.Find("/__________WRS UI__________/Canvas/-----CROPS_TRIGGER/BuildLadder3"))
    //    {
    //        GameObject.Find("/__________WRS UI__________/Canvas/-----CROPS_TRIGGER/Cutscene7Trigger").SetActive(true);
    //        this.gameObject.SetActive(false);
    //        // this.gameObject.GetComponent<OfficetoDirty>().MakeDirty();
    //        //Start Cutscene with boy climbing the ladder and falling

     //   }

        if (eventData.pointerDrag == ItemToInteractWith && this.gameObject == GameObject.Find("/__________WRS UI__________/Canvas/-----CROPS_TRIGGER/ThickBookPlace"))
        {
            this.gameObject.SetActive(false);
            influence.GetComponent<CleanUpReaction>().bookBack = true;
            eventData.pointerDrag.GetComponent<DragDrop>().showdescription = false;
            Light.lighttoggle = false;
        }

        if (eventData.pointerDrag == ItemToInteractWith && this.gameObject == GameObject.Find("/__________WRS UI__________/Canvas/-----CROPS_TRIGGER/ChairPlace"))
        {
            this.gameObject.SetActive(false);
            influence.GetComponent<CleanUpReaction>().chairBack = true;
            eventData.pointerDrag.GetComponent<DragDrop>().showdescription = false;
            Light.lighttoggle = false;
        }

        if (eventData.pointerDrag == ItemToInteractWith && this.gameObject == GameObject.Find("/__________WRS UI__________/Canvas/-----CROPS_TRIGGER/LaundryBasketPlace"))
        {
            this.gameObject.SetActive(false);
            influence.GetComponent<CleanUpReaction>().basketback = true;
            eventData.pointerDrag.GetComponent<DragDrop>().showdescription = false;
            Light.lighttoggle = false;
        }

        if (eventData.pointerDrag == ItemToInteractWith && this.gameObject == GameObject.Find("/__________WRS UI__________/Canvas/-----CROPS_TRIGGER/Dirt"))
        {
            print("cleannn");
            this.gameObject.SetActive(false);
            influence.GetComponent<CleanUpReaction>().cleaned2 = true;
            GameObject.Find("/__________WRS UI__________/Canvas/-----CROPS_TRIGGER/BroomPlace").SetActive(true);
            influence2.SetActive(true);
            eventData.pointerDrag.GetComponent<DragDrop>().showdescription = false;
            influence3.SetActive(false);
            Light.lighttoggle = false;
            Light2.lighttoggle = true;
        }

        if (eventData.pointerDrag == ItemToInteractWith && this.gameObject == GameObject.Find("/__________INTERACTFG__________/Canvas/Trashcan"))
        {
            print("traashed");
            this.gameObject.SetActive(false);
            influence.GetComponent<CleanUpReaction>().cleaned3 = true;
            eventData.pointerDrag.SetActive(false);
            eventData.pointerDrag.transform.SetParent(objects.transform);
            eventData.pointerDrag.GetComponent<DragDrop>().showdescription = false;
            Light.lighttoggle = false;
        }

  //     if (eventData.pointerDrag == ItemToInteractWith && this.gameObject == GameObject.Find("/__________WRS UI__________/Canvas/----- INTERACTABLES/-----DADROOM/Trashcan"))
  //     {
  //         print("trashed");
  //         eventData.pointerDrag.SetActive(false);
  //         eventData.pointerDrag.transform.SetParent(objects.transform);
  //         eventData.pointerDrag.GetComponent<DragDrop>().showdescription = false;
  //     }
    }
}
