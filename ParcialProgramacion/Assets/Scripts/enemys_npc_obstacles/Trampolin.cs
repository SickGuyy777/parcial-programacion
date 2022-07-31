using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampolin : MonoBehaviour
{
    public int fuerzadetrampolin;
    public GameObject sonidotrampolin;
    public Player_comp player;
    private void OnCollisionEnter(Collision collision)
    {
        player.rb.velocity = Vector2.up * fuerzadetrampolin;
        Instantiate(sonidotrampolin);
    }
}
