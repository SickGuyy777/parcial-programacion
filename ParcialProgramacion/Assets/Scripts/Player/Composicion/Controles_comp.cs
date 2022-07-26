using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controles_comp
{
    //composicion hecha por Lautaro Romero
    Movement_comp _movement;
    public Animator animacion;
    public int _salto;
    public npc mecanic;
    public GameObject glasses, UIexpGlasses;
    public Magical_Galsses glass;
    private bool pass, Out;
    public bool explanation;

    public Controles_comp(Movement_comp m, int salto, Animator anim, npc mecanica, GameObject gafas, Magical_Galsses Glass,GameObject UIglasses, bool exp)
    {
        _movement = m;
        _salto = salto;
        animacion = anim;
        mecanic = mecanica;
        glasses = gafas;
        glass = Glass;
        UIexpGlasses = UIglasses;
        explanation = exp;
    }

    public void ArtificialUpdate()
    {
        var v = Input.GetAxis("Vertical");
        var h = Input.GetAxis("Horizontal");
        

        if (v != 0 || h != 0)
        {
            _movement.Move(v, h);
        }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                _movement.Jump();
            }
            else
            {
                animacion.SetBool("TocoPiso", true);
            }

            if(Input.GetKeyDown(KeyCode.Mouse0))
            {
               _movement.attack();
            }
            else
            {
              animacion.SetBool("Ataco", false);
            }

        MagicGlasses();


    
    }

    public void MagicGlasses()
    {

        if (mecanic.gift == true)
        {

            if (explanation==true)
            {
                UIexpGlasses.SetActive(true);
                Out = true;
            }

            


            if (Input.GetKey(KeyCode.E) && Out == true)
            {
                UIexpGlasses.SetActive(false);
                explanation = false;
                pass = true;
                
            }

            if(mecanic.gift==true && explanation==false && pass==true)
            {
                glasses.SetActive(true);
                glass.magic();
            }

        }
    }
}
