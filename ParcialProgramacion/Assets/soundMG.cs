using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundMG : MonoBehaviour
{
    public GameObject sound;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            sound.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            sound.SetActive(false);
        }
    }
}
