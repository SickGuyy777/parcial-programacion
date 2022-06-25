using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void ResetGame()
    {
        Player_comp.score = 0;
        SceneManager.LoadScene("Level1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void VolverAlMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
