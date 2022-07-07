using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class npc : MonoBehaviour
{
    public Transform jugador;
    public float detector;
    public LayerMask layerdeljugador;
    public bool detectoalgo;
    public Animator animaciones;
    public Animator UIanimator;
    public GameObject player;
    public float speedRot;
    public GameObject exclamacion;
    public bool quest, nextext=false;



    public void Start()
    {
       
        quest = false;
    }

    void Update()
    {

        detectoalgo = Physics.CheckSphere(transform.position, detector, layerdeljugador);
        if (detectoalgo == true && player.CompareTag("Player"))
        {
            var dir = jugador.position - transform.position;
            var lerpDir = Vector3.Lerp(transform.forward, dir, Time.deltaTime * speedRot);
            transform.forward = lerpDir;
            if(quest==false)
            {
                exclamacion.SetActive(true);
                UIanimator.SetBool("see", true);
                
                
            }
            else
            {
                
                exclamacion.SetActive(false);
                UIanimator.SetBool("see", false);
            }

        }
        else
        {
            
            exclamacion.SetActive(false);
            UIanimator.SetBool("see", false);
        }
    }


    public void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, detector);
    }

}
