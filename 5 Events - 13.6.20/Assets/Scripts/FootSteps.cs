using UnityEngine;
using UnityEngine.Audio;

public class FootSteps : MonoBehaviour
{
    [SerializeField]

    private AudioSource audioSource;
    
    public AudioClip[] Foreststeps;
    public AudioClip[] Woodsteps;
    CharacterController characterController;
    [Range(-3f, 3f)]
    public float MinPitch;
    [Range(-3f, 3f)]
    public float MaxPitch;
    public Musicswitch musicswitch;
  

    [Range(0f, 1f)]
    public float MinVolume;
    [Range(0f, 1f)]
    public float MaxVolume;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    
      }


    private void Update()
    {

    }

    public void Step()
    {


        if (musicswitch.outside == true)
        {
           
            audioSource.PlayOneShot(Foreststeps[Random.Range(0, Foreststeps.Length)]);
            //audioSource.volume = Random.Range(MinVolume, MaxVolume);
            //audioSource.pitch = Random.Range(MinPitch, MaxPitch);
        }
        else
        {
            audioSource.PlayOneShot(Woodsteps[Random.Range(0, Woodsteps.Length)]);
            
        }

    }

}

   

   
