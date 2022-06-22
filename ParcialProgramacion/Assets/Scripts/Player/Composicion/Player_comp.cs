using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_comp : empty
{
    public int fuerzadetrampolin;
    public float speed;
    public float forceJump;
    public Rigidbody rb;
    public int salto;
    public float vel;
    public float velx;
    public Transform camera;
    public Animator anim;
    public Movement_comp _movement;
    Controles_comp _control;
    public GameObject sonidotrampolin;
    public bool isjump;
    public AudioSource pies;

    private void Start()
    {
        _movement = new Movement_comp(speed, forceJump, rb, transform, anim, isjump, pies);
        _control = new Controles_comp(_movement, salto, vel,velx, camera,anim);
        
    }

    private void Update()
    {
        _control.ArtificialUpdate();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Boton>()?.Touch();
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Trampolin"))
        {
            rb.velocity = Vector2.up * fuerzadetrampolin;
            Instantiate(sonidotrampolin);
        }
    }
}
