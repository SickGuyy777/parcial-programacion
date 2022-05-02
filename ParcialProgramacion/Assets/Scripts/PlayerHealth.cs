using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public Image healthBar;
    public float healthAmout = 5;

    void Update()
    {
        if (healthAmout <= 0)
        {
            SceneManager.LoadScene("Level1");
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            TakeDamage(1);
        }
    }

    public void TakeDamage (float damage)
    {
        healthAmout -= damage;
        healthBar.fillAmount = healthAmout;
    }
}
