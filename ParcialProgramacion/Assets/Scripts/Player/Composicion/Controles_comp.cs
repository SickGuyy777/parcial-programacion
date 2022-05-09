using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controles_comp
{
    Movement_comp _movement;
    int _salto;


    public Controles_comp(Movement_comp m, int salto)
    {
        _movement = m;
        _salto = salto;
       
        
    }

    public void ArtificialUpdate()
    {
        var v = Input.GetAxis("Vertical");
        var h = Input.GetAxis("Horizontal");
        

        if (v != 0 || h != 0)
        {
            _movement.Move(v, h);
        }

      
        if (Input.GetKeyDown(KeyCode.Space))
        {

                _movement.Jump();
            
                
        }
        

    }

    
}
