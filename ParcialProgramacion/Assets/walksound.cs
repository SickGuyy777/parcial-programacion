using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walksound : MonoBehaviour
{
    public AudioClip pies;
    public void soundpies()
    {
        AudioSource.PlayClipAtPoint(pies, transform.position);
    }
}
