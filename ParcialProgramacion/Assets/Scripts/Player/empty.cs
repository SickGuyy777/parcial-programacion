using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class empty :MonoBehaviour   
{
    public float basehealth = 10;
    public float currentHealth;
    public HealthBar healthBar;
    public GameObject sonidodolor;

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
        healthBar.SetHealth(currentHealth);
        Instantiate(sonidodolor);


        if (currentHealth <= 0)
        {
            //isDead = true;
                SceneManager.LoadScene("Perdiste");
                Cursor.lockState = CursorLockMode.None;
        }
    }

    public virtual bool Curacion(float curarse)
    {
        if (curarse > 0 || currentHealth <= 0 || currentHealth == basehealth)
        {

            currentHealth += curarse;

            if (currentHealth > basehealth)
            {
                currentHealth = basehealth;
            }

            if (healthBar != null)
            {
                healthBar.SetHealth(currentHealth);
            }
            return true;
        }
        else
        {
            return false;
        }
        
    }


}
