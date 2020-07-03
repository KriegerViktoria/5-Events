using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Experimental.Rendering.LWRP;


public class doordrop : MonoBehaviour, IDropHandler
{
    public Color numpad_right;
    public Color numpad_wrong;
    public GameObject rightpass;
    public GameObject wrongpass1;
    public GameObject wrongpass2;
    public GameObject mylight;
    public GameObject DoorToOffice;
    public GameObject objects;
    public AudioSource wrongSound;
    public AudioSource rightSound;
    public AudioClip _right;
    public AudioClip _false;
    [Range(0.0f, 1.0f)]
    public float volume;
 

    public void OnDrop(PointerEventData eventData)
    {
        print("dropdoor");
        if (eventData.pointerDrag == rightpass)
        {
            print("Unlock");
            eventData.pointerDrag.SetActive(false);
            eventData.pointerDrag.transform.SetParent(objects.transform);
            DoorToOffice.SetActive(true);
            this.gameObject.SetActive(false);
            GameObject.Find("/__________WRS UI__________/Canvas/-----CROPS_TRIGGER/Cutscene5Trigger").SetActive(true);
            mylight.GetComponent<UnityEngine.Experimental.Rendering.Universal.Light2D>().color = numpad_right;
            //this.gameObject.GetComponent<DialogueTrigger>().TriggerDialogue();
            rightSound.PlayOneShot(_right, volume);
       
        }

        if (eventData.pointerDrag == wrongpass1 || eventData.pointerDrag == wrongpass2 )
        {
            eventData.pointerDrag.SetActive(false);
            eventData.pointerDrag.transform.SetParent(objects.transform);
            mylight.GetComponent<UnityEngine.Experimental.Rendering.Universal.Light2D>().color = numpad_wrong;
            eventData.pointerDrag.GetComponent<DialogueTrigger>().TriggerDialogue();
            rightSound.PlayOneShot(_false, volume);
        }
    }
}