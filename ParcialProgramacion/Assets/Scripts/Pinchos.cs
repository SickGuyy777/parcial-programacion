using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinchos : MonoBehaviour
{
    public int damage;
    public PlayerController Player;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<empty>() != null)
        {
            Player.Damage(damage);
        }
    }
}
