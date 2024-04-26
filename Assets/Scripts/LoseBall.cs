using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseBall : MonoBehaviour
{
    private AudioSource audioSource;
    private void Start()
    {
        LoseMusic m = GetComponent<LoseMusic>();

        audioSource = GetComponent<AudioSource>();
        m.OnCollisionEvent.AddListener(PlayMusic);
    }
    
    private void PlayMusic()
    {
        audioSource.Play(); 
    }
}
