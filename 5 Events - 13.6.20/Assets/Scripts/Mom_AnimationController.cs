using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mom_AnimationController : MonoBehaviour
{
    public Animator MomAnimator;


    public void CutSceneAnim()
    {
        MomAnimator.SetBool("Talk", false);
        MomAnimator.SetBool("Idle", false);

    }

    public void IdleAnim()
    {

        MomAnimator.SetBool("Talk", false);
        MomAnimator.SetBool("Idle", true);
    }

    public void TalkAnim()
    {

        MomAnimator.SetBool("Idle", false);
        MomAnimator.SetBool("Talk", true);
    }
}
