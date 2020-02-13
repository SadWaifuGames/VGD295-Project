using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEndGameSounds : MonoBehaviour
{
    //this script can be added to any canvas element that you want to have a random sound play on becoming visible

    private AudioSource source;

    public AudioClip[] audioClips;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        source.clip = audioClips[Random.Range(0, audioClips.Length)];
        source.Play();

    }

    
}
