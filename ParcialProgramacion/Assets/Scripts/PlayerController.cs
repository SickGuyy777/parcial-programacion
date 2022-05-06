using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : empty
{

    public float speed;
    public float speedRotate;
    public Rigidbody rb;
    public float impulsejump;
    public bool isjump;
    public Animator an;
    public int coinsCollected;
    public int fuerzadetrampolin;

    public void Start()
    {


        isjump = false;
        Cursor.lockState = CursorLockMode.Locked;

    }


    void Update()
    {

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.position += transform.forward * v * speed * Time.deltaTime;
        an.SetFloat("Blend",v);



        transform.Rotate(Vector3.up * h * speedRotate * Time.deltaTime);

        if (isjump)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(Vector3.up * impulsejump, ForceMode.Impulse);
                an.SetBool("jumping",true);

            }
        }
        else
        {
            an.SetBool("jumping", false);
        }


      
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            coinsCollected++;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Trampolin"))
        {
            rb.velocity = Vector2.up * fuerzadetrampolin;
        }
    }
}
