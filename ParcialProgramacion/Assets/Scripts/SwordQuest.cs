using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordQuest : MonoBehaviour
{
    public npc Hsword;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Hsword.Hweapon = true;
            Destroy(this.gameObject);
        }
    }
}
