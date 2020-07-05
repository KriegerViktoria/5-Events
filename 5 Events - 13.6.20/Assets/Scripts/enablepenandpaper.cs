using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enablepenandpaper : MonoBehaviour
{
    public Pickup Pen;
    public Pickup Paper;
    public GameObject lightpen;
    public GameObject lightpaper;
    public lighton light1, light2, light3;
    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            Pen.isNeeded = true;
            Paper.isNeeded = true;
            lightpen.SetActive(true);
            lightpaper.SetActive(true);
            light1.lighttoggle = true;
            light2.lighttoggle = true;
            light3.lighttoggle = true;
        }
    }
}
