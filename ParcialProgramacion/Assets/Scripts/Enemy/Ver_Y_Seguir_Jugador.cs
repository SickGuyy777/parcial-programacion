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
    public int enemigos_derrotados=0;
    public int MaxEnemigos_derrotados;
    public GameObject bloqueodenivel;
    public GameObject sonido_muerte;


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
                    if (_Distancia <= 0.79)
                    {
                        
                    }

                }
                else
                {

                    animaciones.SetBool("ataco", true);
                }





            }
            else
            {
                animaciones.SetBool("corro", false);
            }
        }

        if(enemigos_derrotados==MaxEnemigos_derrotados)
        {
            Destroy(bloqueodenivel);
        }
        Dead();
    }

    public void Dead()
    {
        if(currentHealth < 0)
        {
            enemigos_derrotados++;
            Instantiate(sonido_muerte);
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
