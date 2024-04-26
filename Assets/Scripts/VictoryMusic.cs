using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryMusic : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        
        audioSource = GetComponent<AudioSource>();
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {  
            audioSource.Play(); 
        }
    }
}
