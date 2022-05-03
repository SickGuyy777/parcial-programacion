using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ganaste : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("Meta");
    }
}
