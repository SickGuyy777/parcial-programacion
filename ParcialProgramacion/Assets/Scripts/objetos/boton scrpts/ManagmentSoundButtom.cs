using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagmentSoundButtom : MonoBehaviour
{
    public AudioSource sonido;
    public Boton buttom;
    public void Start()// suscribo al efecto de sonido
    {
        buttom.eventbuttom += EffectSoundAndAnimation;
    }
    public void EffectSoundAndAnimation()
    {
        sonido.Play();
    }
}
