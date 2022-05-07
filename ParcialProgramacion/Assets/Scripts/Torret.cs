using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torret : MonoBehaviour
{
    public Transform target;
    public LayerMask layer;


    void Update()
    {
        var dir = target.position - transform.position;
        var distance = Vector3.Distance(transform.position, target.position);

        if (Physics.Raycast(transform.position, dir, distance, layer))
        {
            transform.forward = dir;
        }
    }

}
