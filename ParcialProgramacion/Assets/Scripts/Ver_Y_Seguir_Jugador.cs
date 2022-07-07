using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ver_Y_Seguir_Jugador : empty
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
    public GameObject player;
    public float speedRot;
    public AudioSource sonidorevivedmg;

    void Update()
    {

        detectoalgo = Physics.CheckSphere(transform.position, detector, layerdeljugador);
        enemigodetectado = Physics.CheckSphere(transform.position, persecucion, layerdeljugador);
        if (detectoalgo == true && player.CompareTag("Player") && currentHealth>0)
        {

            var dir = jugador.position - transform.position;
            var lerpDir = Vector3.Lerp(transform.forward, dir, Time.deltaTime * speedRot);
            transform.forward = lerpDir;
            if (detectoalgo == true && enemigodetectado == true)
            {
                
                var _Distancia = Vector3.Distance(jugador.position, transform.position);
                animaciones.SetBool("corro", true);

                if (_Distancia > 0.79)
                {
                    transform.position = Vector3.MoveTowards(transform.position, new Vector3(jugador.position.x, transform.position.y, jugador.position.z), movespeed * Time.deltaTime);

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
        else
        {
            Dead();
        }

        if(enemigos_derrotados==MaxEnemigos_derrotados)
        {
            Destroy(bloqueodenivel);
        }
    }

    public void Dead()
    {
        if(currentHealth <= 0)
        {
                speedRot = 0;

                animaciones.SetBool("Muerto", true);
                
                enemigos_derrotados++;

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
