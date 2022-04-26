using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton : MonoBehaviour
{
    public Animator Button;
    float _Tiempo;
    public float MaxTime;
    public GameObject ObjetActive;
    void Start()
    {
        Button.SetBool("Toco", false);
        ObjetActive.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        Button.SetBool("Toco", true);
        ObjetActive.gameObject.SetActive(true);


        _Tiempo += Time.deltaTime;
        Debug.Log(_Tiempo);
        if (_Tiempo >= MaxTime)
        {
            Button.SetBool("Toco", false);
            ObjetActive.gameObject.SetActive(false);
        }
    }

 
}
