using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Feet : MonoBehaviour
{
    public Player_comp player;
    private void OnTriggerStay(Collider other)
    {
        player.isjump = true;
    }


    private void OnTriggerExit(Collider other)
    {
        player.isjump = false;
    }
}
