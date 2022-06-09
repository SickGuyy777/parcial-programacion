using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton : MonoBehaviour
{
    public Plataforma_Seve_Noseve platforms;
    public ManagmentSoundButtom sonido;
    public Animator Animationbutton;
    public delegate void Delegatebuttom();
    public event Delegatebuttom eventbuttom;

    void Start()
    {  
        Animationbutton.SetBool("Toco", false);
    }

    public void Touch() //suscripcion de los scripts 
    {
        if(eventbuttom != null)
        {
            Animationbutton.SetBool("Toco", true);
            platforms.ActivePlatforms();
            sonido.EffectSoundAndAnimation();
        }  
    }
    private void OnCollisionEnter(Collision collision) //cuando colisione con el boton se activa el timepo
    {
         platforms._tiempo = true;       
    }
}
