using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _rb;
    public float speed;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        var h = Input.GetAxisRaw("Horizontal");
        var v = Input.GetAxisRaw("Vertical");



        Vector3 dir = new Vector3(h, 0.0f, v);

        transform.position += dir * speed * Time.deltaTime;
        
    }
}
