using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleports : MonoBehaviour
{
    public Transform targuet;
    public GameObject player;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            
            player.transform.position = targuet.transform.position;
            
            player.transform.Rotate(new Vector3 (0f, 180f, 0f));
        }
        
    }
}
