using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanUpReaction : MonoBehaviour
{
    public bool bookBack;
    public bool chairBack;
    public bool basketback;

    public bool cleaned1;
    public bool cleaned2;
    public bool cleaned3;

   public void Reaction()
    {
        if(bookBack && chairBack && basketback)
        {
            cleaned1 = true;
        }

        if (cleaned1 == false && cleaned2 == false && cleaned3 == false)
        {
            print("Reaction1 = worst");
        }

        if (cleaned1 == false && cleaned2 == true && cleaned3 == false || cleaned1 == true && cleaned2 == false && cleaned3 == false || cleaned1 == false && cleaned2 == false && cleaned3 == true)
        {
            print("Reaction1 = neutral");
        }

        if (cleaned1 && cleaned2 && cleaned3 == false|| cleaned2 && cleaned3 && cleaned1 == false|| cleaned1 && cleaned3 && cleaned2 == false)
        {
            print("Reaction2 = neutral");
        }

        if (cleaned3 && cleaned2 && cleaned3)
        {
            print("Reaction3 = best");
        }
    }
}
