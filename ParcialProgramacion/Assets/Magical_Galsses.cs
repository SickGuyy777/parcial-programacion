using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magical_Galsses : MonoBehaviour
{
    public GameObject[] FisicPlane;
    public GameObject[] AstralPlane;
    public bool fisic=true;
    public bool astral= false;


    public void magic()
    {
        if (Input.GetKey(KeyCode.E) && fisic == true)
        {
            fisic = false;
            if (fisic == false)
            {
                for (int i = 0; i < FisicPlane.Length; i++)
                {
                    FisicPlane[i] = AstralPlane[i];
                }
            }

        }
        else
        if(Input.GetKey(KeyCode.E) && fisic == false)
        {
            fisic = true;
            if (fisic == false)
            {
                for (int i = 0; i < FisicPlane.Length; i++)
                {
                    AstralPlane[i] = FisicPlane[i];
                }
            }
        }
    }
}
