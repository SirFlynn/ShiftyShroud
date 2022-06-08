using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject instructions;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (GameIsPaused)
            {
                Resume();
                pauseMenuUI.SetActive(false);
            }
            else
            {
                Pause();
                pauseMenuUI.SetActive(true);
            }
        }
    }
    public void Resume ()
    {
        if (instructions == true)
        {
            instructions.SetActive(true);
        }
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void Pause()
    {
        if (instructions == true)
        {
            instructions.SetActive(false);
        }
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}

