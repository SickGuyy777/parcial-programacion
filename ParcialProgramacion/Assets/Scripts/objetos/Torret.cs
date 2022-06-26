using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torret : MonoBehaviour
{
    public Transform target;
    public float speedRot;
    public LayerMask layers;
    public GameObject balainicio, balaprefab;
    public float timer;
    public float maxTimer;
    public GameObject sonidobala;
    [SerializeField] ParticleSystem humo;

    private void Start()
    {
        timer = maxTimer;       
    }

    void Update()
    {
        var dir = target.position - transform.position;

        var distance = Vector3.Distance(transform.position, target.position);

        if (!Physics.Raycast(transform.position, dir, distance, layers) )
        {
            Disparo();
        }
    }

    protected virtual void Disparo()
    {
        var dir = target.position - transform.position;
        var lerpDir = Vector3.Lerp(transform.forward, dir, Time.deltaTime * speedRot);
            transform.forward = lerpDir;
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                
                GameObject balatemporal = Instantiate(balaprefab, balainicio.transform.position, balainicio.transform.rotation);
                Instantiate(humo, balainicio.transform.position, balainicio.transform.rotation);
                Instantiate(sonidobala);
                
                timer = maxTimer;
            }        
    }
}


