using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MomText : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject continueButton;


    private void Update()
    {
        if (GetComponent.Mom_Kid.Box Collider 2D.Trigger=true)
        
            StartCoroutine(Type());
        
    }

    private void Update()
    {
        if (textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }
    }
    

    IEnumerator Type() {

        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence()
    {
        continueButton.SetActive(false);
        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {

            textDisplay.text = "";
            continueButton.SetActive(false);
        }
    }
}
