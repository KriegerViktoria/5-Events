using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler,IPointerDownHandler, IPointerClickHandler, IPointerUpHandler
{
    [SerializeField] private Canvas canvas;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    Vector3 currentposition;
    GameObject[] nointeractiontext;
    int index;
    public bool showdescription = true;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        nointeractiontext = GameObject.FindGameObjectsWithTag("NoInteraction");
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        showdescription = true;
    }


    public void OnPointerClick(PointerEventData eventData)
    {
      
            this.gameObject.GetComponent<DialogueTrigger>().TriggerDialogue();
      
    }

    public void OnPointerUp(PointerEventData eventData)
    {
      
      //  this.gameObject.GetComponent<DialogueTrigger>().TriggerDialogue();
    }


    public void OnBeginDrag(PointerEventData eventData)
    {
       // Debug.Log("OnBeginDrag");
        canvasGroup.blocksRaycasts = false;
        currentposition = rectTransform.anchoredPosition;
        
    }
    public void OnDrag(PointerEventData eventData)
    {
       // Debug.Log("OnDrag");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        // Debug.Log("OnEndDrag");
        print("enddrag");
        rectTransform.anchoredPosition = currentposition;
        canvasGroup.blocksRaycasts = true;
        index = Random.Range(0, nointeractiontext.Length);

        if (showdescription == true)
        {
           
            nointeractiontext[index].GetComponent<DialogueTrigger>().TriggerDialogue();
        }
    }



}
