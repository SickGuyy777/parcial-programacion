using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//codigo creado por Agustin Ludovico
public class EventManager : MonoBehaviour
{
    public delegate void CollisionAction();
    public static event CollisionAction OnCollision;
    // Start is called before the first frame update
    
    void OnTriggerEnter(Collider mytrigger)
    {
        if(mytrigger.gameObject.name == "player")
        {
            if (OnCollision != null)
            {
                OnCollision();
            }

        }
    }
}
