using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundMG : MonoBehaviour
{
    public AudioSource sound;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            sound.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            sound.Pause();
        }
    }
}
