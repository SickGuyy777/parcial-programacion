using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private Rigidbody _rb;
    //public float speed;

    //void Start()
    //{
    //    _rb = GetComponent<Rigidbody>();
    //}

    //void Update()
    //{
    //    var h = Input.GetAxisRaw("Horizontal");
    //    var v = Input.GetAxisRaw("Vertical");



    //    Vector3 dir = new Vector3(h, 0.0f, v);

    //    transform.position += dir * speed * Time.deltaTime;

    //}
    public float speed;
    public float speedRotate;
    public Rigidbody rb;
    public float impulsejump;
    public bool isjump;


    public void Start()
    {


        isjump = false;
        Cursor.lockState = CursorLockMode.Locked;

    }

    // Update is called once per frame
    void Update()
    {

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");


        transform.position += transform.forward * v * speed * Time.deltaTime;
        transform.Rotate(Vector3.up * h * speedRotate * Time.deltaTime);

        if (isjump)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(Vector3.up * impulsejump, ForceMode.Impulse);

            }
        }



    }
}
