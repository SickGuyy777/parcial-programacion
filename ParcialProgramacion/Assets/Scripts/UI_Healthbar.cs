using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Healthbar : empty
{
    public new int basehealth;
    public new int currentHealth;
    public Image colorvida;

    public void RevisarVida()
    {
        colorvida.fillAmount = basehealth / currentHealth;
    }

    //public Image ColorVida;
    //public void UpdateHealth(int currentHealth, int baseHealth)
    //{
    //  ColorVida.fillAmount = (float)currentHealth / (float)baseHealth;



    //}
}
