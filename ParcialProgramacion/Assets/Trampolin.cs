using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampolin : MonoBehaviour
{
    public int fuerzadetrampolin;
    public GameObject sonidotrampolin;
    Player_comp rb;
    private void OnCollisionEnter(Collision collision)
    {
        rb.rb.velocity = Vector2.up * fuerzadetrampolin;

        Instantiate(sonidotrampolin);
    }
}
