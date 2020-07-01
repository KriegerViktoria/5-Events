using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeColor : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public Color MomColor;
    public Color DadColor;
    public Color GMColor;

    public void MCTalk()
    {
        dialogueText.color = Color.white;
    }

    public void MomTalk()
    {
        dialogueText.color = MomColor;
    }

    public void DadTalk()
    {
        dialogueText.color = DadColor;
    }

   public void GMTalk()
    {
        dialogueText.color = GMColor;
    }
}
