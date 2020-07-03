using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class doortest : MonoBehaviour, IPointerClickHandler

{
    public Animator blendeanim;


    public void OnPointerDown(PointerEventData eventData)
    {
        blendeanim.SetBool("DoorClicked", true);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        blendeanim.SetBool("DoorClicked", false);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
       
    }
}
