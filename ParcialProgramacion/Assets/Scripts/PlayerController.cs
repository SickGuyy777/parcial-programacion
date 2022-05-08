using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : empty
{

    public float speed;
    public float speedRotate;
    public int fuerzadetrampolin;
    public float impulsejump;
    public bool isjump;
    public bool EstoyAtacando;
    public Rigidbody rb;
    public Animator an;
    public GameObject sonidosalto;
    public GameObject pies;
    public ManagementPoints ScriptMoneda;


    public void Start()
    {

        Dead();
        isjump = false;
        Cursor.lockState = CursorLockMode.Locked;
        EstoyAtacando = false;
        
    }


    void Update()
    {

        movimiento();

        
    }
    
    public void movimiento()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

            transform.position += transform.forward * v * speed * Time.deltaTime;
            an.SetFloat("Blend", v);



            transform.Rotate(Vector3.up * h * speedRotate * Time.deltaTime);

            if (isjump)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    rb.AddForce(Vector3.up * impulsejump, ForceMode.Impulse);
                    an.SetBool("salto", true);
                    Instantiate(sonidosalto);
                }
                else
                {
                    an.SetBool("TocoPiso", true);
                }


            }
            else
            {
                cayendo();
            }


            if (Input.GetKeyDown(KeyCode.E))
            {
                
                an.SetBool("Ataco", true);
              

            }
            else
            {
             an.SetBool("Ataco", false);
            }


    }


    private void OnTriggerEnter(Collider other) //composicion
    {
        if (other.CompareTag("Coin"))
        {
            ScriptMoneda.Add(1);

        }
    }

    

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Trampolin"))
        {
            rb.velocity = Vector2.up * fuerzadetrampolin;
        }
    }

    private void cayendo()
    {

        an.SetBool("salto", false);
        an.SetBool("TocoPiso", false);
      
    }

    private void Dead()
    {
        if(currentHealth<=0)
        {
            speed = 0;
            an.SetBool("Muerto", true);
        }
    }

    public void SonidoPies()
    {
        Instantiate(pies);
    }
}
