using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Healthbar : empty
{
    public new int basehealth;
    public new int CurrentHealth;
    public Image ColorVida;

    public void RevisarVida()
    {
        ColorVida.fillAmount = basehealth / CurrentHealth;
    }

    //public Image ColorVida;
    //public void UpdateHealth(int currentHealth, int baseHealth)
    //{
    //  ColorVida.fillAmount = (float)currentHealth / (float)baseHealth;



    //}
}
