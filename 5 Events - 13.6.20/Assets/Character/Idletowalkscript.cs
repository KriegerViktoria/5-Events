using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerScript : MonoBehaviour
{
    public Animator MCAnimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Walk Forwards
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            MCAnimator.SetBool("Walk", true);
        }
        else
        {
            MCAnimator.SetBool("Walk", false);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right;
        }

        //Jump
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.Space))
        {
            MCAnimator.SetBool("Jump", true);
        }
        else
        {
            MCAnimator.SetBool("Jump", false);
        }

        //Walk backwards
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyUp(KeyCode.A))
        {
            transform.Rotate(0, 180, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left;
        }
  

        //Duck
        if (Input.GetKey(KeyCode.S))
        {
            MCAnimator.SetBool("Duck", true);
        }
        else
        {
            MCAnimator.SetBool("Duck", false);
        }

    }
}
