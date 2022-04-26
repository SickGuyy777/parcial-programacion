using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ver_Y_Seguir_Jugador : MonoBehaviour
{
    public Transform jugador;
    public float movespeed;
    public float detector;
    public float persecucion;
    public LayerMask layerdeljugador;
    public bool detectoalgo;
    public bool enemigodetectado;


    void Update()
    {

        detectoalgo = Physics.CheckSphere(transform.position, detector, layerdeljugador);//esto crea una esfera invisible que va a chequear quienes entran y salen de la misma
        enemigodetectado = Physics.CheckSphere(transform.position, persecucion, layerdeljugador);//lo unico diferente que hice fue crear otra area de vision
        if (detectoalgo == true)
        {
            transform.LookAt(jugador);//esto hace que la vista del enemigo siga mi posicion mientras este dentro del area de deteccion

            if (detectoalgo == true && enemigodetectado == true)
            {
                var _Distancia = Vector3.Distance(jugador.position, transform.position);
                if(_Distancia > 0.7)
                {
                    transform.position = Vector3.MoveTowards(transform.position, new Vector3(jugador.position.x, transform.position.y, jugador.position.z), movespeed * Time.deltaTime);//esto hace que me siga
                }
                 
            }
        }

    }

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;//con esto elijo el color de la capsula de vision

        Gizmos.DrawWireSphere(transform.position, detector);//esto dibuja la esfera de deteccion del jugador para que la puedas ver en pantalla (el gizmo)
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, persecucion);

    }
}
