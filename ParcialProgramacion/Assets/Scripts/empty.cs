using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class empty : MonoBehaviour
{
    public float basehealth;
    private float _currentHealth;

    private void Start()
    {
        _currentHealth = basehealth;
    }

    public virtual void Damage(float damage)
    {
        _currentHealth -= damage;
        if(_currentHealth <= 0 )
        {
            Debug.Log("El jugador murio");
        }
    }
}
