using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleitemglow : MonoBehaviour
{
    public GameObject itemglow;
    public GameObject interationglow;

    private void Awake()
    {
        itemglow.SetActive(false);
        interationglow.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            {
            itemglow.SetActive(true);
            interationglow.SetActive(true);

        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            itemglow.SetActive(false);
            interationglow.SetActive(false);

        }
    }

}