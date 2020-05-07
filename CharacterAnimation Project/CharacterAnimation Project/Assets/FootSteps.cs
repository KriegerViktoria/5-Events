using UnityEngine;

public class FootSteps : MonoBehaviour
{
    

    private AudioSource audioSource;
    public AudioClip[] list;
    private new AudioSource audio;
    CharacterController characterController;

    void Start()
    {
        
        audio = GetComponent<AudioSource>();
        characterController = GetComponent<CharacterController>();

        list = new AudioClip[]
        {
        (AudioClip)Resources.Load("Grass Steps 1"),
        (AudioClip)Resources.Load("Grass Steps 2")
        };

    }
    private void Step()
    {
        audio.PlayOneShot(list[Random.Range(0, list.Length)]);
    }

    private void Awake()
   {
        audioSource = GetComponent<AudioSource>();

    }

   

   
}