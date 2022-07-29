using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desactive_objets : MonoBehaviour
{
    public GameObject[] GmObj_act_des;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < GmObj_act_des.Length; i++)
            {
                GmObj_act_des[i].SetActive(false);
            }
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < GmObj_act_des.Length; i++)
            {
                GmObj_act_des[i].SetActive(true);
            }
        }

    }


}
