using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class curacion : MonoBehaviour
{
    public int potenciaDeCuracion;
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            empty hithealth = other.GetComponent<empty>();
            if(hithealth !=null)
            {
               if(hithealth.Curacion(potenciaDeCuracion) == true)
               {
                    Destroy(this.gameObject);
                }
            }
            
        }
    }
}
