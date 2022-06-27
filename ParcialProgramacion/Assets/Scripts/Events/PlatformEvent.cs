using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//codigo creado por Agustin Ludovico
public class PlatformEvent : MonoBehaviour
{
     public GameObject platform;
   
    void OnEnable() 
    {
        EventManager.OnCollision += Platform;
    }

    void OnDisable() 
    {
        EventManager.OnCollision -= Platform;  
       
    }

    void Platform()
    {
     
       
        platform.SetActive(true);

       
   
     

       





       

       
    }
}
