using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crowanim : MonoBehaviour
{
    public float speed;
    public Vector3 end;
   // public Vector3 start;
    
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
       // print(transform.position.y);
        this.gameObject.transform.position += Vector3.right * speed;
        // start = new Vector3(-1.65f, Random.Range(1.04f,1.35f), 0f);

        if (this.gameObject.transform.position.x > end.x)
        {
            this.transform.position = new Vector3(-1.65f, Random.Range(0.4f, 1.4f), 0f);
            speed = Random.Range(0.06f, 0.011f);
        }
    }
}
