using UnityEngine;
using System.Collections;

public class AudioManager : Singleton<AudioManager>
{

    // if you want to use this
    // create a AudioClip , exmapl called it fire
    // example: AudioManager.instance.PlayAudio(fire)

    public AudioSource aSource;

	public void PlayAudio(AudioClip audio)
    {
        //aSource.PlayOneShot(audio);
        aSource.clip = audio;
        aSource.Play();
    }
}
