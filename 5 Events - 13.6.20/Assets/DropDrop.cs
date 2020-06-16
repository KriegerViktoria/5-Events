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
    public void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void OnDrop(PointerEventData eventData)
    {
        currentposition = rectTransform.anchoredPosition;
        //Debug.Log("OnDrop");

        if (eventData.pointerDrag == ItemToDrop)
        {
            DropInScene.SetActive(true);
            DropInScene.transform.position = this.transform.position;
            print("Drop");
            eventData.pointerDrag.SetActive(false);
        }
        //eventData.pointerDrag
    }
}