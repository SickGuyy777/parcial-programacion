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
    public float curarse = 2;

    public bool isDead = false;

    private void Awake()
    {
        currentHealth = basehealth;
        timer = maxTimer;
    }


    public virtual void DamageForPlayer(float dmg)
    {
        currentHealth -= dmg;
        healthBar.SetHealth(currentHealth);
   

        if (currentHealth <= 0)
        {
            //isDead = true;
                SceneManager.LoadScene("Perdiste");
                Cursor.lockState = CursorLockMode.None;
        }
    }

    /*public void Curacion(float curarse)
    {
        
    }*/

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (currentHealth <= 8)
            {
                healthBar.SetHealth(currentHealth);
                currentHealth += curarse;

                //Destroy(this.gameObject);
            }
        }
    }
}
