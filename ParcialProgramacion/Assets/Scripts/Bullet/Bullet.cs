using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : emptyBullet
{

    private Rigidbody _bulletRB;
    private Transform _target;

    public float timer;
    public float maxTimer;

    private void Start()
    {
        _bulletRB = GetComponent<Rigidbody>();

        _target = GameObject.Find("ShootingPoint").transform;

        var dir = _target.position - transform.position;
        _bulletRB.AddForce(dir * speed, ForceMode.Impulse);

        timer = maxTimer;
    }

    void Update()
    {
        timer -= 1 * Time.deltaTime;

        if (timer <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
