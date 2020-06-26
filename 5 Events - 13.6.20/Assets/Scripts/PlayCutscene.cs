using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class PlayCutscene : MonoBehaviour
{
    public PlayableDirector Cutscene;
    public GameObject Trigger;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        {
            Cutscene.Play();
            Trigger.SetActive(false);
        
        }
    }

}
