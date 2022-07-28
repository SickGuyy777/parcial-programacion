using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magical_Galsses : MonoBehaviour
{
    public GameObject[] FisicPlane;
    public GameObject[] AstralPlane;
    public bool active_desacti=false;


    public void Update()
    {
        magic();
    }

    public void magic()
    {
        if (Input.GetKey(KeyCode.E))
        {
            active_desacti = true;
            
            if (active_desacti == true)
            {
                for (int i = 0; i < FisicPlane.Length; i++)
                {
                    FisicPlane[i].SetActive(true);
                }
            }

        }
        
    }
}
