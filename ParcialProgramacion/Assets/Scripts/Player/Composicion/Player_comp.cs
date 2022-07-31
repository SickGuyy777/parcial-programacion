using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player_comp : empty, IScoreCoins_Ui
{
    //composicion hecha por Lautaro Romero TPFINAL


    public float speed;
    public float forceJump;
    public Rigidbody rb;
    public int salto;
    public Animator anim;
    public Animator efectcanvasdead;
    public Movement_comp _movement;
    public Controles_comp _control;
    public bool isjump, expe;
    public AudioClip jump;
    public AudioClip pies;
    public AudioClip amagueespada;
    [Space]
    public GameObject scoreText;
    public npc mecanic;
    public GameObject glasses, UIglasses;
    public Magical_Galsses glass;
    public float LvlTimer = 0;

    public Text textoTimer;

    public static int score;


    private void Start()
    {
        _movement = new Movement_comp(speed, forceJump, rb, transform, anim, isjump);
        _control = new Controles_comp(_movement, salto, anim, mecanic, glasses, glass, UIglasses, expe);

    }


    private void Update()
    {
        _control.ArtificialUpdate();
        UIscorecoins();
        Recivedmg();
        TimerLevel();

    }

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Boton>()?.Touch();
    }


    public void Recivedmg()
    {
        if (currentHealth <= 0)
        {

            timer -= 1 * Time.deltaTime;
            anim.SetBool("Muerto", true);
            speed = 0;
            efectcanvasdead.SetBool("dead", true);
            if (timer <= 0)
            {
                SceneManager.LoadScene("Perdiste");


            }


        }

    }

    public void UIscorecoins()
    {
        scoreText.GetComponent<Text>().text = "" + score;
    }

    public void soundjump()
    {
        AudioSource.PlayClipAtPoint(jump, transform.position);
    }

    public void soundpies()
    {
        AudioSource.PlayClipAtPoint(pies, transform.position);
    }


    public void Amagueespada()
    {
        AudioSource.PlayClipAtPoint(amagueespada, transform.position);
    }

    public void TimerLevel()
    {
        LvlTimer -= Time.deltaTime;

        textoTimer.text = "" + LvlTimer.ToString("f0");

        if (LvlTimer <= 0)
        {
            SceneManager.LoadScene("Perdiste");
        }
    }
}
