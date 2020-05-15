using UnityEngine;

public class FootSteps : MonoBehaviour
{
    [SerializeField]

    private AudioSource audioSource;
    public AudioClip[] list;
    CharacterController characterController;
    [Range(-3f, 3f)]
    public float MinPitch;
    [Range(-3f, 3f)]
    public float MaxPitch;

    [Range(0f, 1f)]
    public float MinVolume;
    [Range(0f, 1f)]
    public float MaxVolume;

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
        //audioSource.volume = Random.Range(MinVolume, MaxVolume);
        //audioSource.pitch = Random.Range(MinPitch, MaxPitch);

    }


   

   
}