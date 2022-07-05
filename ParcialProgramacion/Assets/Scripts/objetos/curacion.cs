using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class curacion : MonoBehaviour
{
    public int potenciadecuracion;
    public GameObject sonidoposion;
    public GameObject efecto;
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {

            empty hithealth = collision.GetComponent<empty>();
            if (hithealth != null)
            {
                Instantiate(sonidoposion);
                Instantiate(efecto, transform.position, transform.rotation);
                if (hithealth.restaurarsalud(potenciadecuracion) == true)
                {
                    Destroy(this.gameObject);
                }
            }
        }
    }
}
