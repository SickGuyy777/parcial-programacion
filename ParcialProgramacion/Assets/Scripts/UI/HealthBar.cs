using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image fillBar;
    public int health;



    public void LoseHealth (int value)
    {
        health -= value;

        fillBar.fillAmount = health / 100;

        //if (health )
    }
}
