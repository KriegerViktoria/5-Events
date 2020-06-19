using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleBool : MonoBehaviour
{
    public Animator MCAnimator;

    public void CutsceneStart()
    {
        MCAnimator.SetBool("Idle", false);
        print("idle false");
    }

    public void CutSceneEnd()
    {
        MCAnimator.SetBool("Idle", true);
    }
}
