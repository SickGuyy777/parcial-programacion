using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionDamage : MonoBehaviour
{
    public float damage;
    public Collider colliderR;
    public float timerCollider;
    public float timerPrefab;

    private void Update()
    {
        timerCollider -= 1 * Time.deltaTime;
        if (timerCollider <= 0)
        {
            Destroy(colliderR);
        }

        timerPrefab -= 1 * Time.deltaTime;
        if (timerPrefab <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        empty hithalth = other.GetComponent<empty>();
        if (hithalth != null)
        {
            hithalth.DamageForPlayer(damage);

            Destroy(colliderR);
        }
    }
}
