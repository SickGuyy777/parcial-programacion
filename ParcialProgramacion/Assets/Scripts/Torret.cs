using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torret : MonoBehaviour
{
    public Transform target;
    public LayerMask layers;
    public GameObject bulletPrefab;
    public float timer;
    public float maxTimer;
    public GameObject sonidobala;

    private void Start()
    {
        timer = maxTimer;
    }


    void Update()
    {
        var dir = target.position - transform.position;
        var distance = Vector3.Distance(transform.position, target.position);
        
            if (!Physics.Raycast(transform.position, dir, distance, layers))
            {
                transform.forward = dir;

                timer -= 1 * Time.deltaTime;

                if (timer <= 0)
                {
                    GameObject projectileInstance = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
                 Instantiate(sonidobala);
                    timer = maxTimer;
                }
            }
    }
}


