using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//codigo creado por Agustin Ludovico
public class SkyboxEvent : MonoBehaviour
{
    public Material matl;
    void OnEnable() 
    {
        EventManager.OnCollision += ChangeSkybox;
    }


   void OnDisable() 
    {
        EventManager.OnCollision -= ChangeSkybox;
    }

    void ChangeSkybox()
    {
      RenderSettings.skybox = matl;
    }
}
