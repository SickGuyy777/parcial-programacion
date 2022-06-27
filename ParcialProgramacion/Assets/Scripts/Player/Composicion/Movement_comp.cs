using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_comp
{
    //composicion hecha por Lautaro Romero
    float _speed;
    float _forceJump;
    Rigidbody _rb;
    public Transform _transform;
    private Animator _anim;
    private bool isjump;
    public AudioSource pies;

    public Movement_comp(float speed, float fj, Rigidbody rb, Transform t, Animator anim, bool estoySaltando, AudioSource sonidoPies)
    {
        _speed = speed;
        _forceJump = fj;
        _rb = rb;
        _transform = t;
        _anim = anim;
        isjump = estoySaltando;
        pies = sonidoPies;
    }

    public void Move(float vertical, float horizontal)
    {
        var dir = _transform.forward * vertical;
        dir += _transform.right * horizontal;

        _transform.position += dir * _speed * Time.deltaTime;
        _anim.SetFloat("Blend", vertical);
        
    }

    public void Jump()
    {
        if (isjump)
        {
            _rb.AddForce(Vector3.up * _forceJump, ForceMode.Impulse);
            _anim.SetBool("salto", true);
        }
    }

    public void attack()
    {
        _anim.SetBool("Ataco", true);
    }

    public void Iamfalling()
    {
        _anim.SetBool("TocoPiso", false);
        _anim.SetBool("salto", false);
    }

    public void SonidoPies()
    {
        pies.Play();
    }

    public bool True()
    {
        return isjump = true;
    }

    public bool False()
    {
        return isjump = false;
    }
}
