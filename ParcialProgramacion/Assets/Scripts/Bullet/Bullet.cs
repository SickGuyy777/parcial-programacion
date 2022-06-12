using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : emptyBullet
{

    private Rigidbody _bulletRB;
    private Transform _target;
    public GameObject Explosion, objbullet;

    public float timer;
    public float maxTimer;
    private string nameTag = "Wall";

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

    private void OnCollisionEnter(Collision pared)
    {
        if(pared.gameObject.tag == nameTag)
        {
            Exploto();
        }
    }

    private void Exploto()
    {
        Destroy(objbullet);
        Instantiate(Explosion, transform.position, transform.rotation);
    }
}
