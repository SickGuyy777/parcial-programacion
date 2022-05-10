using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleports : MonoBehaviour
{
    public Transform targuet;
    public GameObject player;
    
    private void OnTriggerEnter(Collider other)
    {
        player.transform.position = targuet.transform.position;
    }
}
