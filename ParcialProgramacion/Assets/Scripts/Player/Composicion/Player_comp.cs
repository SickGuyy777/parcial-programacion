using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_comp : MonoBehaviour
{
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
}
