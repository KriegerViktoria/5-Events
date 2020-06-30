using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changedialogue : MonoBehaviour
{
 public void changdialogue(GameObject newtextobject)
    {
        newtextobject.SetActive(true);
        this.gameObject.SetActive(false);
    }
    
}
