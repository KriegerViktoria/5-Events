using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfficetoDirty : MonoBehaviour
{
    public SpriteRenderer myrenderer;
    public Sprite newsprite;
    // Start is called before the first frame update
    public void MakeDirty()
    {
        myrenderer.sprite = newsprite;
    }
}
