using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public abstract class empty :MonoBehaviour   
{
    //Codigo de empty creado por Benja Tevez, Lautaro Romero y Nahuel Stagno
    public float basehealth = 10;
    public float currentHealth;
    public Image healthBar;
    public GameObject sonidodolor;
    private float minhealth=9;
    public float timer;
    public float maxTimer;
    public float curarse = 2;

    public bool isDead = false;

    public virtual void Awake()
    {
        currentHealth = basehealth;
        timer = maxTimer;
    }

    public virtual void DamageForPlayer(float dmg)
    {
        currentHealth -= dmg;
        healthBar.fillAmount -= 0.10f;
        Instantiate(sonidodolor);


    }

    public virtual bool Curacion(float curarse)
    {
        if (currentHealth<minhealth)//poner si currenthealth es<minhealth
        {
            currentHealth += curarse;

            if (currentHealth > basehealth)
            {
                currentHealth = basehealth;
            }

            if (healthBar != null)
            {
                healthBar.fillAmount = currentHealth;
            }
            return true;
        }
        else
        {
            return false;
        }
    }

}
