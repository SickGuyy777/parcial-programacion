using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinchos : MonoBehaviour
{
    public int damage;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<PlayerController>() != null)
        {
            other.gameObject.GetComponent<empty>().DamageForPlayer(damage);
        }
    }
}
