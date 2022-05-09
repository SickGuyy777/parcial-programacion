using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class espada : MonoBehaviour
{
    public int damage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Ver_Y_Seguir_Jugador>() != null)
        {
            other.gameObject.GetComponent<empty_Enemy>().DamageForPlayer(damage);
        }
    }
}
