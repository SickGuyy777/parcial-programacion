using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player_comp : empty
{
    //composicion hecha por Lautaro Romero

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

    public bool isjump;
    public AudioSource pies;

    public AudioSource sonidoespada;

    [Space]
    public GameObject scoreText;
    public static int score;

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
            timer -= 1 * Time.deltaTime;
            anim.SetBool("Muerto", true);
            if(timer<=0)
            {
                SceneManager.LoadScene("Perdiste");
                Cursor.lockState = CursorLockMode.None;
            }

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Boton>()?.Touch();
    }

    public void Recivedmg()
    {
        Instantiate(sonidodolor);

        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("Perdiste");
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
