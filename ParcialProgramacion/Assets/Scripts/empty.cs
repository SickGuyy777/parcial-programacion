using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class empty : MonoBehaviour
{
    public float basehealth;
    public float CurrentHealth;

    private void Start()
    {
        basehealth = CurrentHealth;
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
