using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombEnemy : MonoBehaviour
{
    public Transform jugador; //codigo creado por benja teves y lautaro romero
    public float timer;
    public float maxTimer;
    public float movespeed;
    public bool folowing;
    public bool enemigodetectado;
    public Animator animaciones;
    public GameObject explosion;
    public float speedRot;
    public AudioSource sonidorevivedmg;
    public bool setTimer;
    public GameObject model, smokeefect, thisobjet;
    public float mindistance;
    private float _Distancia;


    private void Start()
    {
        timer = maxTimer;
        setTimer = false;
        folowing = false;
        smokeefect.SetActive(false);
        
    }

    void Update()
    {
        if(setTimer==true)
        {
            timer -=  Time.deltaTime;

            if (timer <= 0 && timer>-0.01)
            {
                model.SetActive(false);
                Instantiate(explosion, transform.position, transform.rotation);

                if(timer<=-0.5)
                {
                    thisobjet.SetActive(false);//esto desactiva el controlador del objeto entero
                }
            }

            if (timer <= 1 && timer > 0 || _Distancia< mindistance)
            {
                smokeefect.SetActive(false);
                animaciones.SetBool("explotion", true);
                folowing = false;
                
            }
        }

        Follow();


    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            folowing = true;
        }
    }



    public void Follow()
    {
        if(folowing==true)
        {
            var dir = jugador.position - transform.position;
            var lerpDir = Vector3.Lerp(transform.forward, dir, Time.deltaTime * speedRot);
            transform.forward = lerpDir;
            setTimer = true;
            smokeefect.SetActive(true);
            _Distancia = Vector3.Distance(jugador.position, transform.position);
            animaciones.SetBool("corro", true);

            if (_Distancia > mindistance)
            {
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(jugador.position.x, transform.position.y, jugador.position.z), movespeed * Time.deltaTime);

            }
            


        }



    }


}
