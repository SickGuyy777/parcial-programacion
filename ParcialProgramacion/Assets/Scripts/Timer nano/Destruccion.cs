using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruccion : MonoBehaviour
{
    public Timer Timer;

    public GameObject reloj;

    public float bonusTimer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Timer.timer += bonusTimer;

            reloj.SetActive(false);
        }
    }
}
