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
            empty hithealth = other.GetComponent<empty>(); // cambiar las partes donde dice empty en este renglon y y ver que hay en el scrpt de player de herencia para ver como lo cura y pasarlo a la composicion del player original 
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
