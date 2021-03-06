using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : HitBox
{
    public Rigidbody rb;    //Creado por Benjamin teves y Modificado por Lautaro Romero TPFINAL
    public float radiusDamage;
    public float durationExplosion;
    public GameObject sonidoexplosion;

    float _timer;
    

    private void Update()
    {
        _timer += Time.deltaTime;

        if (_timer >= durationExplosion)
        {
            Instantiate(sonidoexplosion);
            Collider[] colliders = Physics.OverlapSphere(transform.position, radiusDamage);

            for (int i = 0; i < colliders.Length; i++)
            {
                var c = colliders[i].GetComponent<Rigidbody>();

                if (c != null)
                {
                    c.AddForce(Vector3.up * 10, ForceMode.Impulse);
                }
            }

            Destroy(gameObject);
        }
    }
}
