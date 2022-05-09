using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logica_De_Pies : MonoBehaviour
{

   public PlayerController player ;



    private void OnTriggerStay(Collider other)
    {
        player.isjump =true;
    }


    private void OnTriggerExit(Collider other)
    {
        player.isjump =false;
    }
}
