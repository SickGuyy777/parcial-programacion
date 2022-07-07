using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool isPaused;
    public npc npc;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    private void Start()
    {
        pauseMenu.SetActive(false);
        text1.SetActive(false);
        text2.SetActive(false);
        text3.SetActive(false);
        text4.SetActive(false);
    }



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }

    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void NPCchat()
    {
        if(npc.UIanimator.GetBool("see"))
            if(Input.GetKeyDown(KeyCode.E) && npc.quest==false)
            {
                text1.gameObject.SetActive(false);
                text2.gameObject.SetActive(true);
                if (Input.GetKeyDown(KeyCode.R) && npc.quest ==false)//por si dice que no
                {
                    Debug.Log("dijo que no");
                    

                    text3.gameObject.SetActive(true);
                    text2.gameObject.SetActive(false);
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                     
                    }
                }

                if (Input.GetKeyDown(KeyCode.Q) && npc.quest == false)// por si dice que si
                {
                    Debug.Log("dijo que si");
                    text4.SetActive(true);
                    npc.quest = true;
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        //npc.UIanimator.SetBool("see", false);
                        
                    }

                }
            }


        
        

    }
}
