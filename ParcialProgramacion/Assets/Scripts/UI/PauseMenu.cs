using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool isPaused;
    public npc npc;
    public GameObject text1, text2, text3, text4;
    private int pass=0;
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

        NPCchat();

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
        
        if (pass==0)
        {
            text1.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            pass++;
            if(pass==1)
            {
                text2.SetActive(true);
                text1.SetActive(false);
            }

            if (Input.GetKeyDown(KeyCode.R))//por si dice que no
            {
                Debug.Log("dijo que no");
                pass++;
                if(pass==2)
                {
                    text3.SetActive(true);
                    text2.SetActive(false);
                }

                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        
                    }
            }
            else
            if (Input.GetKeyDown(KeyCode.Q))// por si dice que si
            {
                Debug.Log("dijo que si");
                text4.SetActive(true);
                
               if (Input.GetKeyDown(KeyCode.E))
               {
                npc.UIanimator.SetBool("see", false);
                npc.quest = true;
               }

            }
        }
        

    }
}
