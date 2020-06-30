using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToggle : MonoBehaviour
{


    public void disablemove()
    {
        this.gameObject.layer = 0;
    }

    public void enablemove()
    {
        print("enable");
        this.gameObject.layer = 2;
    }
        }

