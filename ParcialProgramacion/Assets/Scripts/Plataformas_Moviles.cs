using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataformas_Moviles : MonoBehaviour
{
    public Rigidbody RbPLatform;
    public Transform [] PositionsPlatforms;
    public float PlatformSpeed;

    private int _ActualPosition=0;
    private int _NextPosition=1;
    
    // Update is called once per frame
    void Update()
    {
        _Movment(); 
    }
    void _Movment()
    {
        RbPLatform.MovePosition(Vector3.MoveTowards(RbPLatform.position, PositionsPlatforms[_NextPosition].position, PlatformSpeed * Time.deltaTime));

        if(Vector3.Distance(RbPLatform.position, PositionsPlatforms[_NextPosition].position) <=0 )
        {
            _ActualPosition = _NextPosition;
            _NextPosition++;
            if(_NextPosition > PositionsPlatforms.Length - 1)
            {
                _NextPosition = 0;
            }
        }
    }
}
