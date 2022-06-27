using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleports : MonoBehaviour
{
    public Transform targuet;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            other.transform.position = targuet.transform.position;
            
            other.transform.Rotate(new Vector3 (0f, 180f, 0f));
        }
    }
}
