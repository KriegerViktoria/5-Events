using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textonlyonce : MonoBehaviour
{
  public void textonce()
    {
        this.gameObject.GetComponent<DialogueTrigger>().enabled = false;
    }
}
