using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emptyBullet : MonoBehaviour
{
    public float speed;
    public int damage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<empty>() != null)
        {
            other.gameObject.GetComponent<empty>().DamageForPlayer(damage);
        }

        Destroy(this.gameObject);
    }
}
