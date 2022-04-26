using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton : MonoBehaviour
{
    public Animator Button;
    public float TiempoInicial;
    float _CurrentTime;
    float _MinTime=0;
    public GameObject ObjetActive;
    bool _Tiempo = false;
    void Start()
    {
        Button.SetBool("Toco", false);
        ObjetActive.gameObject.SetActive(false);
        _CurrentTime = TiempoInicial;
    }

    private void Update()
    {
        if (_Tiempo == true)
        {
            Button.SetBool("Toco", true);
            ObjetActive.gameObject.SetActive(true);

            _CurrentTime -= Time.deltaTime;
            Debug.Log(_CurrentTime);
            
            if (_CurrentTime <= _MinTime)
            {
                _Tiempo = false;
                _CurrentTime = TiempoInicial;
                Button.SetBool("Toco", false);
                ObjetActive.gameObject.SetActive(false);
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        _Tiempo = true;
    }



}
