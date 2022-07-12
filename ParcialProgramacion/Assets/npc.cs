using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class npc : MonoBehaviour
{
    //codigo creado por Lautaro Romero
    public Transform jugador;
    public float detector;
    public LayerMask layerdeljugador;
    public bool detectoalgo;
    public Animator animaciones;
    public Animator UIanimator;
    public GameObject player;
    public float speedRot;
    public GameObject exclamacion;
    public bool quest,next,No,Yes,Out;
    public GameObject[] textUI;
    public float cooldown;
    public float maxtime;
 
    // en cada rama de la conversacion se ve que desactivo todos los carteles exepto uno, con eso logro que en el caso de que te hayas negado o aceptado la quest los textos no se sobrepongan cuando estan activados


    public void Start()
    {
        
        for (int i = 0; i < textUI.Length; i++)
        {
            textUI[i].SetActive(false);
        }
        quest = false;
        cooldown = maxtime;
    }

    void Update()
    {

        detectoalgo = Physics.CheckSphere(transform.position, detector, layerdeljugador);
        if (detectoalgo == true && player.CompareTag("Player"))
        {
            var dir = jugador.position - transform.position;
            var lerpDir = Vector3.Lerp(transform.forward, dir, Time.deltaTime * speedRot);
            transform.forward = lerpDir;

        }
        
        Mision();
        CoolDownQuest();
    }

    public void Mision()
    {
        if (next == true)// hacer los if por ceparado fue la unica forma de hacer que funcionen los carteles
        {
            if (Input.GetKey(KeyCode.E) && Out==false)// aca entra el segundo cartel en el que le pide que busque su espada
            {
                textUI[0].SetActive(false);
                textUI[1].SetActive(true);
                textUI[2].SetActive(false);
                textUI[3].SetActive(false);
                textUI[4].SetActive(false);
                No = true;
                Yes = true;
            }

            if (Input.GetKey(KeyCode.R) && No == true)//por si dice que no
            {
                textUI[0].SetActive(false);
                textUI[1].SetActive(false);
                textUI[2].SetActive(true);
                textUI[3].SetActive(false);
                textUI[4].SetActive(false);
                Out = true;
                Yes = false;

            }

            if (Input.GetKey(KeyCode.Q)&& Yes==true)//por si dice que si
            {       
                textUI[0].SetActive(false);
                textUI[1].SetActive(false);
                textUI[2].SetActive(false);
                textUI[3].SetActive(true);
                textUI[4].SetActive(false);
                Out = true;
                No = false;
            }

            if (Input.GetKey(KeyCode.E) && Out == true)// con esto al terminar la conversacion el cartel de la quest se desactiva y crea un cooldown
            {
                if(No==true && Out==true)
                {
                   
                    exclamacion.SetActive(false);
                    UIanimator.SetBool("see", false);
                    quest = true;
                }

                if(Yes==true && Out==true)
                {
                   
                    exclamacion.SetActive(false);
                    UIanimator.SetBool("see", false);


                }

            }
        }


    }

    public void CoolDownQuest()// un cooldow de corto tiempo para cuando el jugador acepte o niegeue la quest
    {
        if (No == true && Out == true && quest==true)
        {
            cooldown -= 1 * Time.deltaTime;
            if (cooldown <= 0)// receteo todos los boleanos para cuando cuelva a entrar
            {
                quest = false;
                cooldown = maxtime;
                Out = false;
                No = false;
                Yes = false;
            }
        }

        if (No == false && Out == true && Yes == true)
        {
            cooldown -= 1 * Time.deltaTime;
            if (cooldown <= 0)
            {
                quest = true;
                cooldown = maxtime;

            }
        }


    }

    private void OnTriggerEnter(Collider other) // inicia desde aca
    {
        if (other.CompareTag("Player") && quest == false)// ni bien entre el npc inicia llamandolo
        { 
            textUI[0].SetActive(true);
            textUI[1].SetActive(false);
            textUI[2].SetActive(false);
            textUI[3].SetActive(false);
            textUI[4].SetActive(false);
            exclamacion.SetActive(true);
            UIanimator.SetBool("see", true);

           next = true;// una vez que next sea true inicia las preguntas del update
        }
        else
        if(other.CompareTag("Player") && quest == true && Yes== true)
        {
            UIanimator.SetBool("see", true);
            textUI[0].SetActive(false);
            textUI[1].SetActive(false);
            textUI[2].SetActive(false);
            textUI[3].SetActive(false);
            textUI[4].SetActive(true);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            if (quest == false)
            {
                for (int i = 0; i < textUI.Length; i++)
                {
                    textUI[i].SetActive(false);
                }
                exclamacion.SetActive(false);
                UIanimator.SetBool("see", false);

            }

        }
    }

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, detector);
    }

  

}
