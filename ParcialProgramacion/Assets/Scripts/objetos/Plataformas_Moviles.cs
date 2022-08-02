using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataformas_Moviles : MonoBehaviour
{

    public Transform [] positionsPlatforms;
    public float platformSpeed;

    private int _actualPosition=0;
    public bool movetothenext = true;




    void Update()
    {
        _Movment(); 
    }
    public void _Movment()
    {

        if(Vector3.Distance(transform.position,positionsPlatforms[_actualPosition].transform.position) < 0.1f)
        {
            _actualPosition++;
            if(_actualPosition>= positionsPlatforms.Length)
            {
                _actualPosition = 0;
            }

            
        }
        transform.position = Vector3.MoveTowards(transform.position, positionsPlatforms[_actualPosition].transform.position, platformSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.SetParent(null);
        }
    }
}

