using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropDrop : MonoBehaviour, IDropHandler
{
    public GameObject ItemToDrop;
    public GameObject DropInScene;
    private RectTransform rectTransform;
    Vector3 currentposition;
    private GameObject objects;
    public lighton light2;
    public void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        objects = GameObject.Find("__________CAM UI__________/Canvas/Objects");
    }

    public void OnDrop(PointerEventData eventData)
    {
        currentposition = rectTransform.anchoredPosition;
        eventData.pointerDrag.GetComponent<DragDrop>().showdescription = false;
        //Debug.Log("OnDrop");

        if (eventData.pointerDrag == ItemToDrop)
        {
            DropInScene.SetActive(true);
            DropInScene.transform.position = this.transform.position;
            DropInScene.GetComponent<Pickup>().isNeeded = false;
            print("Drop");
            eventData.pointerDrag.SetActive(false);
            eventData.pointerDrag.transform.SetParent(objects.transform);
            if(this.gameObject == GameObject.Find("/__________WRS UI__________/Canvas/-----CROPS_TRIGGER/BroomPlace"))
            {
                light2.lighttoggle = false;
            }
            
        }
        //eventData.pointerDrag
    }
}