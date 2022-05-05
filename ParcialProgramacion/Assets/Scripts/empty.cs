using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class empty : MonoBehaviour
{
    public float basehealth;
    public float CurrentHealth;


    private void Awake()
    {
        CurrentHealth = basehealth;
    }

    public virtual void Damage(float dmg)
    {
        CurrentHealth -= dmg;
        if(CurrentHealth <= 0 )
        {
            SceneManager.LoadScene("Perdiste");
            Cursor.lockState = CursorLockMode.None;
        }
    }


}
