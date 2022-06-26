using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : emptyBullet
{

    
    public GameObject  objbullet;
    public ParticleSystem Explosion;

    public bool once = true;

    public float timer;
    public float maxTimer;
    private string nameTag1 = "Wall";
    private string nameTag2 = "Player";
    private void Start()
    {
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

    private void OnCollisionEnter(Collision objeto)
    {
        if(objeto.gameObject.tag == nameTag1 && once || objeto.gameObject.tag == nameTag2)
        {
            var em = Explosion.emission;
            var dur = Explosion.duration;
            em.enabled = true;
            once= false;
            Exploto();
            em.enabled = false;
        }
    }

    private void Exploto()
    {
        Destroy(objbullet);
        Instantiate(Explosion, transform.position, transform.rotation);
        
    }
}
