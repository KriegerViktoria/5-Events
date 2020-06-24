using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dad_AnimationController : MonoBehaviour
{
    public Animator DadAnimator;


  public void CutSceneAnim()
    {
        DadAnimator.SetBool("Talk", false);
        DadAnimator.SetBool("Idle", false);
        DadAnimator.SetBool("Lift", false);


    }

    public void IdleAnim()
    {
        DadAnimator.SetBool("Talk", false);
        DadAnimator.SetBool("Idle", true);
        DadAnimator.SetBool("Lift", false);
    }

    public void TalkAnim()
    {

        DadAnimator.SetBool("Idle", false);
        DadAnimator.SetBool("Talk", true);
        DadAnimator.SetBool("Lift", false);
    }

    public void LiftAnim()
    {

        DadAnimator.SetBool("Idle", false);
        DadAnimator.SetBool("Talk", false);
        DadAnimator.SetBool("Lift", true);
    }
}
