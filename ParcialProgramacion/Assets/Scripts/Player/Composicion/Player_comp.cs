using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_comp : MonoBehaviour
{
    public float speed;
    public float forceJump;
    public Rigidbody rb;
    public int salto;

    Movement_comp _movement;
    Controles_comp _control;


    private void Start()
    {
        _movement = new Movement_comp(speed, forceJump, rb, transform);
        _control = new Controles_comp(_movement, salto);
        
    }

    private void Update()
    {
        _control.ArtificialUpdate();
        
    }
}
