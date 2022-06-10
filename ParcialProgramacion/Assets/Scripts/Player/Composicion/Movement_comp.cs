using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_comp
{
    float _speed;
    float _forceJump;
    Rigidbody _rb;
    public Transform _transform;

    public Movement_comp(float speed, float fj, Rigidbody rb, Transform t)
    {
        _speed = speed;
        _forceJump = fj;
        _rb = rb;
        _transform = t;
    }

    public void Move(float vertical, float horizontal)
    {
        var dir = _transform.forward * vertical;
        dir += _transform.right * horizontal;

        _transform.position += dir * _speed * Time.deltaTime;
    }

    public void Jump()
    {
        _rb.AddForce(Vector3.up * _forceJump, ForceMode.Impulse);

    }
}
