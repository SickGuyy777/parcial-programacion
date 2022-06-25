using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PiedraConMovimiento : MonoBehaviour
{
    //trabajo echo por nahuel
    public GameObject PiedraMovimiento;

    public Transform startPoint;
    public Transform endPoint;

    public float timer;
    public float maxTimer;

    public float velocidad;
    private string player = "Player";
    private Vector3 MoverHacia;
    
    //donde se posiciona en un principio el objeto 
    void Start()
    {
        MoverHacia = endPoint.position;
        maxTimer = timer;
    }

    // movimiento del objeto y timer
    void Update()
    {
        PiedraMovimiento.transform.position = Vector3.MoveTowards(PiedraMovimiento.transform.position, MoverHacia, velocidad * Time.deltaTime);      
        
        if (PiedraMovimiento.transform.position == endPoint.position)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                MoverHacia = startPoint.position;
                timer = maxTimer;
            }           
        }

        if (PiedraMovimiento.transform.position == startPoint.position)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                MoverHacia = endPoint.position;
                timer = maxTimer;
            }        
        }
    }

    //tabajo echo por nahuel y lautaro
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == player)
        {
            SceneManager.LoadScene("Perdiste");
        }
    }
}
