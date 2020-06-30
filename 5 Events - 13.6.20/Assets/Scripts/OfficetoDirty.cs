using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfficetoDirty : MonoBehaviour
{
    public SpriteRenderer myrenderer;
    public Sprite newsprite;
    public GameObject trash;
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
        GameObject.Find("/__________Collectibles_______/Book").GetComponent<Pickup>().isNeeded = true;
        GameObject.Find("/__________Collectibles_______/Book").layer = 0;
        GameObject.Find("/__________Collectibles_______/ErsteHilfeSet").SetActive(false);
        trash.SetActive(true);

    }
}
