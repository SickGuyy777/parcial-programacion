using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruccion : MonoBehaviour
{
    public Player_comp Timer; // Hecho por Nahuel Stagno TPFINAL
    public GameObject reloj;
    public AudioSource cam;
    public AudioClip sound;
    public float bonusTimer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Timer.LvlTimer += bonusTimer;

            reloj.SetActive(false);
            cam.PlayOneShot(sound);
        }
    }
}
