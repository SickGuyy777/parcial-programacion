using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagmentSoundButtom : MonoBehaviour
{
    //codigo creado por Lautaro Romero
    public AudioSource audioSource;
    public Boton buttom;
    public AudioClip sound;
    public void Start()// suscribo al efecto de sonido
    {
        buttom.eventbuttom += EffectSoundAndAnimation;
    }
    public void EffectSoundAndAnimation()
    {
        audioSource.PlayOneShot(sound);
    }
}
