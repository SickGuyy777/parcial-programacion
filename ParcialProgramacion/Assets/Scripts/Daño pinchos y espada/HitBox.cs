using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBox : MonoBehaviour
{
    [SerializeField] private int damage;
    //codigo base creado por Lautaro Romero y modificado por Nahuel Stagno, Benja Tevez
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<empty>() != null)
        {
            other.gameObject.GetComponent<empty>().DamageForPlayer(damage);
        }
    }
}
