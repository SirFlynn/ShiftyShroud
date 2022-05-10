using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject levelFailedUI;
    public GameObject levelCompleteUI;
    public static bool GameIsPaused = false;
    public PauseMenu pauseMenu;

    private void Start()
    {
        //Calls from sripts in the gameobject
        pauseMenu = GetComponent<PauseMenu>();
    }


    public void LevelFailed()
    {
        Debug.Log("Level Failed");
        levelFailedUI.SetActive(true);
        GameIsPaused = true;
    }



    public void LevelComplete()
    {
        Debug.Log("Level Complete");
        levelCompleteUI.SetActive(true);
        PauseMenu.GameIsPaused = true;
        pauseMenu.Pause();
    }
}
