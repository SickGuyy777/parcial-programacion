using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class empty_Enemy : MonoBehaviour
{
    public int basehealth;
    public int currentHealth;


    private void Awake()
    {
        currentHealth = basehealth;

    }

    public virtual void DamageForPlayer(int dmg)
    {
        currentHealth -= dmg;

        if (currentHealth <= 0)
        {



        }

    }
}
