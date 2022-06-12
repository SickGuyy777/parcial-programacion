using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma_Seve_Noseve : MonoBehaviour
{
    public GameObject objetActive;
    public Boton buttom;
    float _currentTime;
    float _minTime = 0;
    public float tiempoInicial;
    public bool _tiempo = false;
    public void Start()//suscribo al controlador de las plataformas y desde aca hago el cotador para que se active y desactive segun el tiempo que me guste a mi
    {
        _currentTime = tiempoInicial;
        objetActive.SetActive(false);
        buttom.eventbuttom += ActivePlatforms;
    }
    public void ActivePlatforms()
    {
        objetActive.SetActive(true);
    }
    private void Update()
    {
        if (_tiempo == true)
        {
            _currentTime -= Time.deltaTime;
            Debug.Log(_currentTime);

            if (_currentTime <= _minTime)
            {
                objetActive.SetActive(false);
                _tiempo = false;
                _currentTime = tiempoInicial;
                buttom.Animationbutton.SetBool("Toco",false);
            }
        }
    }
}
