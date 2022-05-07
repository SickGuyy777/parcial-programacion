using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class empty : MonoBehaviour
{
    public int basehealth;
    public int CurrentHealth;
    public UI_Healthbar health_bar;

    private void Awake()
    {
        CurrentHealth = basehealth;
    }

    public virtual void DamageForPlayer(int dmg)
    {
        CurrentHealth -= dmg;
        //health_bar.UpdateHealth(CurrentHealth, basehealth);
        if(CurrentHealth <= 0 )
        {
            SceneManager.LoadScene("Perdiste");
            Cursor.lockState = CursorLockMode.None;
        }
    }


}
