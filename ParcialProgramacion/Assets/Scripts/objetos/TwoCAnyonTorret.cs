using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoCAnyonTorret : Torret 
{
    public GameObject balainicio2, balaprefab2;

    [SerializeField] ParticleSystem humo2;

    

    protected override void Disparo()
    {
    
        base.Disparo();
        
    
        var dir = target.position - transform.position;
        var lerpDir = Vector3.Lerp(transform.forward, dir, Time.deltaTime * speedRot);
        transform.forward = lerpDir;
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            
            GameObject balatemporal = Instantiate(balaprefab2, balainicio2.transform.position, balainicio.transform.rotation);
            Instantiate(humo2,balainicio2.transform.position, balainicio2.transform.rotation);
            Instantiate(sonidobala);
            
            
            timer = maxTimer;
        }

           


            
            

        
    }



}
    

