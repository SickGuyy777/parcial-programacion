using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public GameObject sonidoMoneda;

    private void OnTriggerEnter(Collider other)
    {
        var player = other.gameObject.GetComponent<IScoreCoins_Ui>();
        if (player!=null)
        {
            Player_comp.score += 1;
            Destroy(this.gameObject);

            Instantiate(sonidoMoneda);
        }
    }
}
