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
    public LaserParticle laserParticleScript;

    public AudioSource laserZap;

    private void Start()
    {
        //Calls from sripts in the gameobject
        pauseMenuScript = GetComponent<PauseMenu>();
        pauseMenuScript.enabled = true;
        pauseMenuScript.Resume();
        mouseControllerScript.enabled = true;
        laserParticleScript.enabled = true;
    }


    public void LevelFailed()
    {
        laserZap.Play();

        //waits for one second and then runs the LevelFailUI public void code
        Invoke("LevelFailUI", 1);

        //Disables the laser and mouse particle scripts so that the player cannot move and the laser does not continue to trigger the LevelFailed public void. 
        laserParticleScript.enabled = false;
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
