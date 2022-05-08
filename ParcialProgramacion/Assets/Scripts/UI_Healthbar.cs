using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Healthbar : empty
{
    public float basehealth;
    public float currentHealth;
    public Image colorvida;

    private void Start()
    {
        basehealth = currentHealth;
    }

    private void Update()
    {
        
    }
}
