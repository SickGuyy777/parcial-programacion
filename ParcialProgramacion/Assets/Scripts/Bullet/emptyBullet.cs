using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emptyBullet : MonoBehaviour
{
    public float speed;
    private int damage = 2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<empty>() != null)
        {
            other.gameObject.GetComponent<empty>().DamageForPlayer(damage);
        }

        Destroy(this.gameObject);
    }
}
