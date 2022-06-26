using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinchosDamage : MonoBehaviour
{
    public int damage = 1;
    public empty emptyScript;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            emptyScript.currentHealth -= damage;
        }
    }
}
