using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Healthbar : MonoBehaviour
{
    public Image fillImage;
    public void UpdateHealth(int currentHealth, int baseHealth)
    {
        fillImage.fillAmount = (float)currentHealth / (float)baseHealth;
    }
}
