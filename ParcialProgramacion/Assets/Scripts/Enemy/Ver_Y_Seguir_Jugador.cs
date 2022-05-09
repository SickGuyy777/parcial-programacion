using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ver_Y_Seguir_Jugador : empty_Enemy
{
    public Transform jugador;
    public float movespeed;
    public float detector;
    public float persecucion;
    public LayerMask layerdeljugador;
    public bool detectoalgo;
    public bool enemigodetectado;
    public Animator animaciones;


    void Update()
    {

        detectoalgo = Physics.CheckSphere(transform.position, detector, layerdeljugador);
        enemigodetectado = Physics.CheckSphere(transform.position, persecucion, layerdeljugador);
        if (detectoalgo == true)
        {
           
            transform.LookAt(jugador);

            if (detectoalgo == true && enemigodetectado == true)
            {
                
                var _Distancia = Vector3.Distance(jugador.position, transform.position);
                animaciones.SetBool("corro", true);

                if (_Distancia > 0.79)
                {
                    transform.position = Vector3.MoveTowards(transform.position, new Vector3(jugador.position.x, transform.position.y, jugador.position.z), movespeed * Time.deltaTime);
                    if(_Distancia <=0.79)
                    {
                        animaciones.SetBool("ataco", true);
                    }

                    

                }
                 
            }
            else
            {
                animaciones.SetBool("corro", false);
            }
        }

        Dead();
    }

    public void Dead()
    {
        if(currentHealth<=0)
        {
            
            animaciones.SetBool("Muerto", true); 
        }
    }

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;

        Gizmos.DrawWireSphere(transform.position, detector);
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, persecucion);

    }
}
