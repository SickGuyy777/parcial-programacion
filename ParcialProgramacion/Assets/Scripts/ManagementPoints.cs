using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagementPoints : MonoBehaviour
{
    int _recolectado;
    public GameObject SonidoMoneda;
    public Text scoretext;
    public void Add(int Puntos)
    {
        
        _recolectado += Puntos;
        Instantiate(SonidoMoneda);
        scoretext.text = "X" + _recolectado;

    }
}
