using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class empty :MonoBehaviour
{
    public float basehealth = 10;
    public float currentHealth;
    public HealthBar healthBar;

    public float timer;
    public float maxTimer;

    public bool isDead = false;

    private void Awake()
    {
        currentHealth = basehealth;
    }



    public virtual void DamageForPlayer(float dmg)
    {
        currentHealth -= dmg;
        healthBar.SetHealth(currentHealth);
        Curacion(2);

        if (currentHealth <= 0)
        {
            isDead = true;

            if (timer <= 0)
            {
                SceneManager.LoadScene("Perdiste");
                Cursor.lockState = CursorLockMode.None;
            } 
        }
    }

    public void Curacion(float curarse)
    {
        if(currentHealth<10)
        {
            currentHealth += curarse;

        }
    }
}
