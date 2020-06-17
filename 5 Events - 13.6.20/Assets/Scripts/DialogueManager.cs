using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour {

    public GameObject continueButton;
    public TextMeshProUGUI dialogueText;

    public PointandClickScript PSScript;

	private Queue<string> sentences;

	// Use this for initialization
	void Start () {
		sentences = new Queue<string>();
      
    }

	public void StartDialogue (Dialogue dialogue)
	{
        PSScript.isMoving = false;

        print("Still Starting Dialogue");
        //animator.SetBool("IsOpen", true);
     
		sentences.Clear();

		foreach (string sentence in dialogue.sentences)
		{
			sentences.Enqueue(sentence);
            PSScript.enabled = false;
        }

		DisplayNextSentence();
	}

	public void DisplayNextSentence ()
	{
		if (sentences.Count == 0)
		{
			EndDialogue();
			return;
		}

		string sentence = sentences.Dequeue();
		StopAllCoroutines();
		StartCoroutine(TypeSentence(sentence));
        
    }

	IEnumerator TypeSentence (string sentence)
	{
       
        dialogueText.text = "";
		foreach (char letter in sentence.ToCharArray())
		{
			dialogueText.text += letter;
			yield return null;
            continueButton.SetActive(true);
        }
	}

	void EndDialogue()
	{
        continueButton.SetActive(false);
        dialogueText.text = "";
        PSScript.enabled = true;


        //animator.SetBool("IsOpen", false);
    }

}