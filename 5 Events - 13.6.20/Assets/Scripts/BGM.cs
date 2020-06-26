using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    public AudioSource ForestBGM;
    public AudioSource HouseBGM;
    public Musicswitch musicswitch;
   

    private void Update()
    {
        if (musicswitch.outside)
        {
            HouseBGM.enabled = false;
            ForestBGM.enabled = true;
        }
        else
        {
            HouseBGM.enabled = true;
            ForestBGM.enabled = false;
        }

    }
}
