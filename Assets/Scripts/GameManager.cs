using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject levelFailedUI;
    public GameObject levelCompleteUI;
    public static bool GameIsPaused = false;
    public PauseMenu pauseMenuScript;
    public MouseController mouseControllerScript;

    public float TimeUntilEnd = 0.5f;

    public AudioSource laserZap;

    public GameObject[] laserScripts;

    private void Start()
    {
        //Calls from sripts in the gameobject
        pauseMenuScript = GetComponent<PauseMenu>();
        pauseMenuScript.enabled = true;
        pauseMenuScript.Resume();
        mouseControllerScript.enabled = true;

        ToggleLaserScript(true);
    }

    //toggleLaser with set everything in array to either true or false based on bool
    public void ToggleLaserScript(bool toggleLaser)
    {
        for (int i = 1; i < laserScripts.Length; i++)
        {
            laserScripts[i].GetComponent<LaserParticle>().enabled = toggleLaser;
        }
    }

    public void LevelFailed()
    {
        laserZap.Play();

        //waits for one second and then runs the LevelFailUI public void code
        Invoke("LevelFailUI", TimeUntilEnd);

        //Disables the laser and mouse particle scripts so that the player cannot move and the laser does not continue to trigger the LevelFailed public void. 
        ToggleLaserScript(false);
        mouseControllerScript.enabled = false;
    }

    public void LevelFailUI()
    {
        levelFailedUI.SetActive(true);
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
