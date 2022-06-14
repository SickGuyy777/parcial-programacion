using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : emptyBullet
{

    
    public GameObject Explosion, objbullet;

    public float timer;
    public float maxTimer;
    private string nameTag = "Wall";

    private void Start()
    {
        //_target = GameObject.Find("ShootingPoint").transform;
        timer = maxTimer;
        
    }

    void Update()
    {
        Rigidbody _bulletRB = GetComponent<Rigidbody>();
        _bulletRB.AddForce(transform.forward * speed);
        timer -= Time.deltaTime;

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
