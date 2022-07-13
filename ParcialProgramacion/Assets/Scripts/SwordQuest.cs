using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordQuest : MonoBehaviour
{
    public npc Hsword;
    public Animator UIplayer;
    public GameObject text,model;
    public bool activechat;
    public Player_comp p;
    public void Update()
    {
        iconplayerUI();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Hsword.Hweapon = true;
            p.expe = true;
            activechat = true;
            Destroy(model);
            UIplayer.SetBool("tengo", true);
            text.SetActive(true);
        }
    }

    public void iconplayerUI()
    {
        if(Input.GetKey(KeyCode.R) && activechat==true)
        {
            UIplayer.SetBool("tengo", false);
            text.SetActive(false);
        }
    }
}
