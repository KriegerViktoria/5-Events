using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueTrigger : MonoBehaviour {

	public Dialogue dialogue;
	public bool playonce;
	public void TriggerDialogue ()
	{
        print("Start Dialogue");
		FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
		if (playonce == true )
		{
			this.gameObject.GetComponent<Image>().enabled = false;
		}
	}

}
