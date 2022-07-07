using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            other.GetComponent<Player_comp>().ReloadChecks(transform.position.x,transform.position.y,transform.position.z);
        }
    }
}
