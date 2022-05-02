using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleports : MonoBehaviour
{
    public Transform Targuet;
    public GameObject Player;
    private void OnTriggerEnter(Collider other)
    {
        Player.transform.position = Targuet.transform.position;
    }
}
