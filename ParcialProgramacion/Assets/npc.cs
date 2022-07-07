using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    public bool questacept=false;
    public GameObject text1, text2, text3, text4;
    public void Start()
    {
        text1.SetActive(false);
        text2.SetActive(false);
        text3.SetActive(false);
        text4.SetActive(false);
    }

    void Update()
    {

        detectoalgo = Physics.CheckSphere(transform.position, detector, layerdeljugador);
        if (detectoalgo == true && player.CompareTag("Player"))
        {
            var dir = jugador.position - transform.position;
            var lerpDir = Vector3.Lerp(transform.forward, dir, Time.deltaTime * speedRot);
            transform.forward = lerpDir;
            if (questacept == false)
            {
                exclamacion.SetActive(true);
                UIanimator.SetBool("see", true);
                text1.SetActive(true);
                if(Input.GetKeyDown(KeyCode.E))
                {
                    text2.SetActive(true);
                    text1.SetActive(false);
                    
                    if(Input.GetKeyDown(KeyCode.R))
                    {
                        text2.SetActive(false);
                        text3.SetActive(true);
                        
                        if(Input.GetKeyDown(KeyCode.E))
                        {
                            UIanimator.SetBool("see", false);
                        } 
                    }
                    else
                    if(Input.GetKeyDown(KeyCode.Q))
                    {
                        text4.SetActive(true);
                        exclamacion.SetActive(false);
                        if(Input.GetKeyDown(KeyCode.E))
                        {
                            UIanimator.SetBool("see", false);
                            questacept = true;
                        }
                        
                    }
                }
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
