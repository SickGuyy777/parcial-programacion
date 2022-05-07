using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : empty
{

    public float speed;
    private Rigidbody _bulletRB;
    public Transform target;
    public float timer;
    public float maxTimer;
    public int damage;

    private void Start()
    {
        _bulletRB = GetComponent<Rigidbody>();

        target = GameObject.Find("ShootingPoint").transform;

        var dir = target.position - transform.position;
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<empty>() != null)
        {
            other.gameObject.GetComponent<empty>().DamageForPlayer(damage);
        }

        Destroy(this.gameObject);
    }
}
