using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class empty :MonoBehaviour   
{
    //Codigo de empty creado por Benja Tevez, Lautaro Romero y Nahuel Stagno
    public float basehealth = 10;
    public float currentHealth;
    public Image healthBar;   
    public float timer;
    public float maxTimer;
    public bool isDead = false;


    public GameObject sonidodolor;

    public virtual void Awake()
    {
        currentHealth = basehealth;
        timer = maxTimer;

    }

    public virtual void DamageForPlayer(float damage)
    {
        currentHealth -= damage;
        healthBar.fillAmount -= damage / currentHealth;
    }

    public bool restaurarsalud(int healingamount)
    {
        if (healingamount > 0 || currentHealth <= 0 || currentHealth == basehealth)
        {

            currentHealth += healingamount;
            healthBar.fillAmount += healingamount / currentHealth;
            if (currentHealth > basehealth)
            {
                currentHealth = basehealth;
            }

            return true;
        }
        else
        {
            return false;
        }

    }

}
