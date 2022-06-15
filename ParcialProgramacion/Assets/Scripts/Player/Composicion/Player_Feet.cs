using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Feet : MonoBehaviour
{
    public Player_comp player;
    private void OnTriggerStay(Collider other)
    {
        player._movement.True();
        player.anim.SetBool("TocoPiso", true);
        player._movement.Iamfalling();
    }

    private void OnTriggerExit(Collider other)
    {
        player._movement.False();
    }
}
