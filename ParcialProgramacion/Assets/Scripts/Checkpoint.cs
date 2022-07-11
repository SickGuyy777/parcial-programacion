using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Checkpoint : MonoBehaviour
{
    //public bool check;
    [Header("Checkpoints")]
    public GameObject Start, End;
    public GameObject[] Cheackpoints;

    private void OnTriggerEnter(Collider other)
    {
        //check = true;
        //if(other.CompareTag("Player") && check==true)
        //{
        //    other.GetComponent<Player_comp>().ReloadChecks(transform.position.x,transform.position.y,transform.position.z);
        //}
        //else
        //{
        //    SceneManager.LoadScene("Level1");
        //}

    }
}
