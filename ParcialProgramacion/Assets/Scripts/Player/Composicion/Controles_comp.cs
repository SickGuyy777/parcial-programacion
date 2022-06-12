using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controles_comp
{
    Movement_comp _movement;
    public int _salto;
    public Transform Camera;
    public float sensitivecam;
    public float limitrotatr;
    public float rotateXcam;
    public Controles_comp(Movement_comp m, int salto, float vel, float velx, Transform camera)
    {
        _movement = m;
        _salto = salto;
        sensitivecam = vel;
        limitrotatr = velx;
        rotateXcam = velx;
        Camera = camera;

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

        rotateXcam += -Input.GetAxis("Mouse Y");
        rotateXcam = Mathf.Clamp(rotateXcam, -limitrotatr, limitrotatr);

        
        Camera.localEulerAngles = new Vector3(rotateXcam, Camera.localEulerAngles.y, Camera.localEulerAngles.z);
        _movement._transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivecam, 0);
        
        
    }

    
}