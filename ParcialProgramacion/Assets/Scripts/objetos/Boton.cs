using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton : MonoBehaviour
{
    public Animator button;
    public float tiempoInicial;
    float _currentTime;
    float _minTime=0;
    public GameObject objetActive;
    bool _tiempo = false;
    public GameObject sonidoBoton;
    void Start()
    {
        button.SetBool("Toco", false);
        objetActive.gameObject.SetActive(false);
        _currentTime = tiempoInicial;
    }

    private void Update()
    {
        if (_tiempo == true)
        {
            button.SetBool("Toco", true);
            objetActive.gameObject.SetActive(true);

            _currentTime -= Time.deltaTime;
            Debug.Log(_currentTime);
            
            if (_currentTime <= _minTime)
            {
                _tiempo = false;
                _currentTime = tiempoInicial;
                button.SetBool("Toco", false);
                objetActive.gameObject.SetActive(false);
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        _tiempo = true;
        Instantiate(sonidoBoton);
    }



}
