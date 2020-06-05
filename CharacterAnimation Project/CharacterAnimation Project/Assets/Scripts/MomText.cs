using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MomText : MonoBehaviour
{
    public TextMeshProUGUI textDisplayMom;
    public string[] sentencesMom;
    private int indexMom;
    public float typingSpeedMom;
    public GameObject continueButtonMom;


    public void StartText()
    {
        print("Starting TypeMom");
        StartCoroutine(TypeMom());
    }

    private void Update()
    {
        if (textDisplayMom.text == sentencesMom[indexMom])
        {
            continueButtonMom.SetActive(true);
        }
    }


    IEnumerator TypeMom()
    {
        print("Still starting TypeMom");
        foreach (char letter in sentencesMom[indexMom].ToCharArray())
        {
            textDisplayMom.text += letter;
            yield return new WaitForSeconds(typingSpeedMom);
        }
    }

    public void NextSentence()
    {
        continueButtonMom.SetActive(false);
        if (indexMom < sentencesMom.Length - 1)
        {
            indexMom++;
            textDisplayMom.text = "";
            StartCoroutine(TypeMom());
        }
        else
        {

            textDisplayMom.text = "";
            continueButtonMom.SetActive(false);
        }
    }
}
