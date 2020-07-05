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
    public GameObject passwordtext1;
    public GameObject passwordtext2;
    public AudioSource wrongSound;
    public AudioSource rightSound;
    public AudioClip _right;
    public AudioClip _false;
    public GameObject boylifttext;
    public lighton light1;
    public lighton light2;
    public lighton light3;
    [Range(0.0f, 1.0f)]
    public float volume;
    public GameObject penandpaper;
 

    public void OnDrop(PointerEventData eventData)
    {
        print("dropdoor");
        eventData.pointerDrag.GetComponent<DragDrop>().showdescription = false;
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
            boylifttext.SetActive(true);
            wrongpass1.transform.SetParent(objects.transform);
            wrongpass1.SetActive(false);
            wrongpass2.transform.SetParent(objects.transform);
            wrongpass2.SetActive(false);
            penandpaper.SetActive(false);
           penandpaper.transform.SetParent(objects.transform);
            light1.lighttoggle = false;
            light2.lighttoggle = false;
            light3.lighttoggle = false;
        }

        if (eventData.pointerDrag == wrongpass1)
        {
            eventData.pointerDrag.SetActive(false);
            eventData.pointerDrag.transform.SetParent(objects.transform);
            mylight.GetComponent<UnityEngine.Experimental.Rendering.Universal.Light2D>().color = numpad_wrong;
            passwordtext1.GetComponent<DialogueTrigger>().TriggerDialogue();
            rightSound.PlayOneShot(_false, volume);
        }

        if (eventData.pointerDrag == wrongpass2)
        {
            eventData.pointerDrag.SetActive(false);
            eventData.pointerDrag.transform.SetParent(objects.transform);
            mylight.GetComponent<UnityEngine.Experimental.Rendering.Universal.Light2D>().color = numpad_wrong;
            passwordtext2.GetComponent<DialogueTrigger>().TriggerDialogue();
            rightSound.PlayOneShot(_false, volume);
        }

    }
}