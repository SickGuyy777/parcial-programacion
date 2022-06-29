using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public GameObject sonidoMoneda;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Player_comp.score += 1;
            Destroy(this.gameObject);

            Instantiate(sonidoMoneda);
        }
    }
}
