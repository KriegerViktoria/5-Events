using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfficetoDirty : MonoBehaviour
{
    public SpriteRenderer myrenderer;
    public Sprite newsprite;
    public GameObject trash;
    public GameObject broom;
    public GameObject stuhl;
    public GameObject kiste;
    // Start is called before the first frame update
    public void MakeDirty()
    {
        myrenderer.sprite = newsprite;
        GameObject.Find("/__________WRS UI__________/Canvas/-----CROPS_TRIGGER/ThickBookPlace").SetActive(true);
        GameObject.Find("/__________WRS UI__________/Canvas/-----CROPS_TRIGGER/LaundryBasketPlace").SetActive(true);
        GameObject.Find("/__________WRS UI__________/Canvas/-----CROPS_TRIGGER/ChairPlace").SetActive(true);
        GameObject.Find("/__________WRS UI__________/Canvas/-----CROPS_TRIGGER/Dirt").SetActive(true);
        GameObject.Find("/__________WRS UI__________/Canvas/-----CROPS_TRIGGER/Trashcan").SetActive(true);
        GameObject.Find("/__________WRS UI__________/Canvas/-----CROPS_TRIGGER/ReactionTrigger").SetActive(true);
       // GameObject.Find("/__________Collectibles_______/Book").GetComponent<Pickup>().isNeeded = true;
        GameObject.Find("/__________Collectibles_______/Book").GetComponent<Pickup>().inRange = true;
        GameObject.Find("/__________Collectibles_______/Book").layer = 0;
        GameObject.Find("/__________Collectibles_______/ErsteHilfeSet").SetActive(false);
        trash.SetActive(true);
        broom.GetComponent<Pickup>().isNeeded = true;
        stuhl.GetComponent<Pickup>().isNeeded = true;
        kiste.GetComponent<Pickup>().isNeeded = true;
    }
}
