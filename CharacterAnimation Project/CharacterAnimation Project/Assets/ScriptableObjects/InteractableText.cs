using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractableText : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    //public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject continueButton;
    public GameObject SelectedItem;
    


    public void StartType()
    {
       // StartCoroutine(Type());
    }

    private void OnMouseDown(GameObject selectedItem)
    {
       // StartCoroutine(Type());
        selectedItem = SelectedItem;
        print("Selected " + SelectedItem.name);
    }

  //  private void Update()
  //  {
  //      if (textDisplay.text == SelectedItem.)
  //      {
  //          continueButton.SetActive(true);
  //      }
  //  }
  //
  //
  //  IEnumerator Type()
  //  {
  //
  //      foreach (char letter in SelectedItem.description.ToCharArray())
  //      {
  //          textDisplay.text += letter;
  //          yield return new WaitForSeconds(typingSpeed);
  //      }
  //  }
  //
  //  public void NextSentence()
  //  {
  //      continueButton.SetActive(false);
  //      if (index < SelectedItem.description.Length - 1)
  //      {
  //          index++;
  //          textDisplay.text = "";
  //          StartCoroutine(Type());
  //      }
  //      else
  //      {
  //
  //          textDisplay.text = "";
  //          continueButton.SetActive(false);
  //      }
  //  }
} //
  //