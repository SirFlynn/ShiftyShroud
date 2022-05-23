using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject levelFailedUI;
    public GameObject levelCompleteUI;
    public static bool GameIsPaused = false;
    public PauseMenu pauseMenuScript;

    private void Start()
    {
        //Calls from sripts in the gameobject
        pauseMenuScript = GetComponent<PauseMenu>();
        pauseMenuScript.enabled = true;
        pauseMenuScript.Resume();
    }


    public void LevelFailed()
    {
        Debug.Log("Level Failed");
        levelFailedUI.SetActive(true);
        PauseMenu.GameIsPaused = true;
        pauseMenuScript.Pause();
        //stops the player from being able to press esc and unpause the game.
        pauseMenuScript.enabled = false;
    }



    public void LevelComplete()
    {
        Debug.Log("Level Complete");
        levelCompleteUI.SetActive(true);
        PauseMenu.GameIsPaused = true;
        pauseMenuScript.Pause();
        pauseMenuScript.enabled = false;
    }
}
