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

        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("Perdiste");
            Cursor.lockState = CursorLockMode.None;
        }

        //lo copie y pegue en Player_comp
    }

    public virtual bool Curacion(float curarse)
    {
        if (curarse > 0 || currentHealth != basehealth)
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
