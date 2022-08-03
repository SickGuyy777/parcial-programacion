using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : HitBox
{

    public float speed;
    public GameObject  objbullet;
    public ParticleSystem Explosion;

    public bool once = true;

    public float timer;
    public float maxTimer;
    public string[] nametags; //a futuro
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


    private void Exploto()
    {
        Destroy(objbullet);
        Instantiate(Explosion, transform.position, transform.rotation);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Wall") || other.gameObject.CompareTag("Player"))
        {

            var em = Explosion.emission;
            var dur = Explosion.duration;
            em.enabled = true;
            once = false;
            Exploto();
            em.enabled = false;
        }
    }
}
