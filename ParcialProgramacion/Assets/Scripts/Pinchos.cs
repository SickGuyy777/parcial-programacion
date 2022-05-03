using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinchos : MonoBehaviour
{
    public float damage;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<empty>() != null)
        {
            other.gameObject.GetComponent<empty>().Damage(damage);
        }
    }
}
