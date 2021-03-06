using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour {

    public GameObject continueButton;
    public TextMeshProUGUI dialogueText;

    public PointandClickScript PSScript;
	public Animator MCAnimator;
    public Animator Blackbar;
    public GameObject FG1;
    public GameObject FG2;
    

    private Queue<string> sentences;

	// Use this for initialization
	void Start () {
		sentences = new Queue<string>();

	}

	public void StartDialogue (Dialogue dialogue)
	{
        ////
        //dialogueText.color = dialogue.TextColor;
        ////
        FG1.SetActive(false);
        FG2.SetActive(false);
        PSScript.isMoving = false;
		MCAnimator.SetBool("Walk", false);
        Blackbar.SetBool("Dialogue", true);
    
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

            if (dialogueText.text == sentence) {

                continueButton.SetActive(true);
            }
            else {
                continueButton.SetActive(false);
            }
        }
	}

	void EndDialogue()
	{
        continueButton.SetActive(false);
        dialogueText.text = "";
        PSScript.enabled = true;
        Blackbar.SetBool("Dialogue", false);
        FG1.SetActive(true);
        FG2.SetActive(true);
        //animator.SetBool("IsOpen", false);
    }

}
