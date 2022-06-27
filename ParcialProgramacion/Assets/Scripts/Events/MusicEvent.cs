using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//codigo creado por Agustin Ludovico
public class MusicEvent : MonoBehaviour
{
   
    public AudioClip musica_de_accion;

    AudioSource audioSourse;
    void OnEnable() 
    {
        EventManager.OnCollision += ChangeMusic;
    }


//    void OnDisable() 
//     {
//         Eventmanager.OnCollision -= ChangeMusic;
//     }

    void ChangeMusic()
    {
        audioSourse = GetComponent<AudioSource>();

        audioSourse.clip = musica_de_accion;

        audioSourse.Play();
        EventManager.OnCollision -= ChangeMusic;
     
    }
}
