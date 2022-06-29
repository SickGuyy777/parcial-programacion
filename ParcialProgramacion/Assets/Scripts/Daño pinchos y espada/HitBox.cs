using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBox : MonoBehaviour
{
    public GameObject sonidoEspada;
    public GameObject sonidoDolor;
    public float damage;
    //codigo base creado por Lautaro Romero y modificado por Nahuel Stagno, Benja Tevez
    private void OnTriggerEnter(Collider other)
    {
            empty hithalth = other.GetComponent<empty>();
            if(hithalth!=null)
            {
                Instantiate(sonidoEspada);
                Instantiate(sonidoDolor);
                hithalth.DamageForPlayer(damage);               
            }
        
    }
}
