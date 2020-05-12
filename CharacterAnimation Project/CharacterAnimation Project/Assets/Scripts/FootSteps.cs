using UnityEngine;

public class FootSteps : MonoBehaviour
{
    [SerializeField]

    private AudioSource audioSource;
    public AudioClip[] list;
    CharacterController characterController;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();

    }

    void Start()
    {
        

    }
    private void Step()
    {
        audioSource.PlayOneShot(list[Random.Range(0, list.Length)]);
    }


   

   
}