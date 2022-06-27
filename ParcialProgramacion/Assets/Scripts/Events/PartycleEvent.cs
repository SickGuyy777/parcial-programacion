using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartycleEvent : MonoBehaviour
{
   //codigo creado por Agustin Ludovico
   public ParticleSystem ps;
    void OnEnable() 
    {
        EventManager.OnCollision += Startparticles;
    }

    void OnDisable() 
    {
        EventManager.OnCollision -= Startparticles;
    }

    void Startparticles()
    {
       var em = ps.emission;
       em.enabled = true;
    }
}
