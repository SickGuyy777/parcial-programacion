using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{
    [SerializeField] private Transform[] positions;
    [SerializeField] private Transform Player;
    private int CheckCount = 1;

    private void OnTriggerEnter(Collider other)
    {
        CharacterController CHC = Player.GetComponent<CharacterController>();
        if(other.CompareTag("Checkponts"))
        {
            BoxCollider Bcol = other.gameObject.GetComponent<BoxCollider>();
            Bcol.enabled = false;
            CheckCount ++;
        }
    }

}
