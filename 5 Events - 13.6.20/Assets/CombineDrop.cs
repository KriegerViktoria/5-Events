using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CombineDrop : MonoBehaviour, IDropHandler
{
    public GameObject ItemToCombineWith;
    public GameObject Result;
    private RectTransform rectTransform;
    Vector3 currentposition;
    public void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void OnDrop(PointerEventData eventData)
    {
        currentposition = rectTransform.anchoredPosition;
       // Debug.Log("OnDrop");

        if (eventData.pointerDrag == ItemToCombineWith)
        {
            
            print("Combine");
            Result.transform.position = this.transform.position;
            eventData.pointerDrag.SetActive(false);
            this.gameObject.SetActive(false);
            
        }
        //eventData.pointerDrag
    }
}
