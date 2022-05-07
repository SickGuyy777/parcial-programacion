using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class empty : MonoBehaviour
{
    public int basehealth;
    public int currentHealth;
    public UI_Healthbar health_bar;

    private void Awake()
    {
        currentHealth = basehealth;
    }

    public virtual void DamageForPlayer(int dmg)
    {
        currentHealth -= dmg;
        //health_bar.UpdateHealth(CurrentHealth, basehealth);
        if(currentHealth <= 0 )
        {
            SceneManager.LoadScene("Perdiste");
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
