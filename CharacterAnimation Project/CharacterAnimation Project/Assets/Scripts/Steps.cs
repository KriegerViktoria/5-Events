using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steps : MonoBehaviour
{

    public AudioClip[] list;
    AudioSource newAudio;
    CharacterController characterController;
    int number;

    void Start()
    {
        newAudio = GetComponent<AudioSource>();
        characterController = GetComponent<CharacterController>();
        //Loading the items into the array
        list = new AudioClip[]
        {
        (AudioClip)Resources.Load("Grass 1"),
        (AudioClip)Resources.Load("Grass 2"),

        };
    }



}

