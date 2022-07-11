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
    public bool quest;
    public GameObject[] textUI;




    public void Start()
    {
        
        for (int i = 0; i < textUI.Length; i++)
        {
            textUI[i].SetActive(false);
        }
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

        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("entro detecto al player");
            var dir = jugador.position - transform.position;
            var lerpDir = Vector3.Lerp(transform.forward, dir, Time.deltaTime * speedRot);
            transform.forward = lerpDir;
            if (quest == false)
            {
                Debug.Log("la quest sigue siendo falsa");
                textUI[0].SetActive(true);
                exclamacion.SetActive(true);
                UIanimator.SetBool("see", true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("presione la e");
                    textUI[0].SetActive(false);
                    textUI[1].SetActive(true);
                }
            }
        }

    }
    public void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, detector);
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
            else
            {

            }
        }
    }

}
