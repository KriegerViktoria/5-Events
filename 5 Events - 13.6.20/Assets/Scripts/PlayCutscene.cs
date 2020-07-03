using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class PlayCutscene : MonoBehaviour
{
    public PlayableDirector Cutscene;
    public GameObject Trigger;


    private void OnTriggerStay2D(Collider2D collision)
    {
        {
            if (collision.CompareTag("Player"))
            {
                Cutscene.Play();
                Trigger.SetActive(false);
            }
        
        }
    }

}
