using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataformas_Moviles : MonoBehaviour
{
    public Rigidbody RbPLatform;
    public Transform [] positionsPlatforms;
    public float platformSpeed;

    private int _actualPosition;
    private int _nextPosition=1;
    
    // Update is called once per frame
    void Update()
    {
        _Movment(); 
    }
    void _Movment()
    {
        RbPLatform.MovePosition(Vector3.MoveTowards(RbPLatform.position, positionsPlatforms[_nextPosition].position, platformSpeed * Time.deltaTime));

        if(Vector3.Distance(RbPLatform.position, positionsPlatforms[_nextPosition].position) <=0 )
        {
            _actualPosition = _nextPosition;
            _nextPosition++;
            if(_nextPosition > positionsPlatforms.Length - 1)
            {
                _nextPosition = 0;
            }
        }
    }
}
