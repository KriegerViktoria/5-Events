using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueTrigger : MonoBehaviour {

	public Dialogue dialogue;

	public void TriggerDialogue ()
	{
        print("Start Dialogue");
		FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
	}

}
