using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player_comp : empty
{
    //composicion hecha por Lautaro Romero
    public int fuerzadetrampolin;
    public float speed;
    public float forceJump;
    public Rigidbody rb;
    public int salto;
    public float vel;
    public float velx;
    public new Transform camera; 
    public Animator anim;
    public Movement_comp _movement;
    public Controles_comp _control;
    public GameObject sonidotrampolin;
    public bool isjump;
    public AudioSource pies;

    public AudioSource sonidoespada;

    [Space]
    public GameObject scoreText;
    public static int score;

    public int pinchosDamage; 

    private void Start()
    {
        _movement = new Movement_comp(speed, forceJump, rb, transform, anim, isjump, pies);
        _control = new Controles_comp(_movement, salto, vel,velx, camera,anim, sonidoespada);
        
    }

    private void Update()
    {
        _control.ArtificialUpdate();

        scoreText.GetComponent<Text>().text = "" + score;

        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("Perdiste");
            Cursor.lockState = CursorLockMode.None;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Boton>()?.Touch();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Trampolin"))
        {
            rb.velocity = Vector2.up * fuerzadetrampolin;
            Instantiate(sonidotrampolin);
        }

        if (other.gameObject.CompareTag("Pinchos"))
        {
            DamageUI(1);
            currentHealth -= pinchosDamage;
        }
    }

    public void DamageUI(float value)
    {
        currentHealth -= value;
        healthBar.fillAmount -= 0.10f;
        Instantiate(sonidodolor);
    }
}
