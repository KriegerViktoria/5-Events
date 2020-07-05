using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using UnityEngine;

public class playpiano : MonoBehaviour
{
    public AudioSource randomSound;
    public AudioClip[] AudioClips;
    public float volume;
    // Start is called before the first frame update

    public void playthepiano()
    {
        print("play");
        randomSound.clip = AudioClips[Random.Range(0, AudioClips.Length)];
        randomSound.PlayOneShot(randomSound.clip, volume);
    }

  //  public void RandomSoundness()
  //  {
  //
  //  }
} //
