using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grandmother_AnimationController : MonoBehaviour
{
    public Animator GMAnimator;


    public void CutSceneAnim()
    {
        GMAnimator.SetBool("Idle", false);

    }

    public void IdleAnim()
    {
        GMAnimator.SetBool("Idle", true);
    }

    
}


