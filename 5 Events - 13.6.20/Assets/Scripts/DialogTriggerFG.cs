using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTriggerFG : MonoBehaviour
{
    public Dialogue dialogue;
    public void TriggerDialogueFG()
    {
        print("Start DialogueFG");
    
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
 
    }
}
