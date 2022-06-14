using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject levelFailedUI;
    public GameObject levelCompleteUI;
    public static bool GameIsPaused = false;
    public PauseMenu pauseMenuScript;
    public GameObject optionsMenuUI;
    public MouseController mouseControllerScript;
    public GameObject instructions;

    [SerializeField] private CanvasGroup failMenuFade;
    [SerializeField] private CanvasGroup winMenuFade;
    [SerializeField] private bool failMenuFadeIn = false;
    [SerializeField] private bool winMenuFadeIn = false;

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

    //Ensures that the pause menu cannot be opened in the options menu
    void Update()
    {
        // if the player fails, then start fading in the level failed UI
        if (failMenuFadeIn)
        {
            levelFailedUI.SetActive(true);

            if (failMenuFade.alpha < 1)
            {
                failMenuFade.alpha += Time.deltaTime;
                if (failMenuFade.alpha >= 1)
                {
                    failMenuFadeIn = false;
                }
            }
        }

        // if the player wins, then start fading in the win failed UI
        if (winMenuFadeIn)
        {
            levelCompleteUI.SetActive(true);

            if (winMenuFade.alpha < 1)
            {
                winMenuFade.alpha += Time.deltaTime;
                if (winMenuFade.alpha >= 1)
                {
                    winMenuFadeIn = false;
                }
            }
        }

        //check to see if the options menu is open and if it is then the pause menu script is disabled
        if (optionsMenuUI.activeSelf)
        {
            pauseMenuScript.enabled = false;
        }

        else
        {
            pauseMenuScript.enabled = true;
        }
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

        if(instructions == true)
        {
            instructions.SetActive(false);
        }

        //waits for one second and then runs the LevelFailUI public void code
        Invoke("LevelFailUI", TimeUntilEnd);

        //Disables the laser and mouse particle scripts so that the player cannot move and the laser does not continue to trigger the LevelFailed public void. 
        ToggleLaserScript(false);
        mouseControllerScript.enabled = false;
    }

    public void LevelFailedCat()
    {
        //waits for one second and then runs the LevelFailUI public void code
        Invoke("LevelFailUI", TimeUntilEnd);

        //Disables the laser and mouse particle scripts so that the player cannot move and the laser does not continue to trigger the LevelFailed public void. 
        ToggleLaserScript(false);
        mouseControllerScript.enabled = false;
    }

    public void LevelFailUI()
    {
        //levelFailedUI.SetActive(true);
        //myUIGroup.alpha = 1;

        //fadeIn = true;

        // Starts the code of the FailMenu function found within the first IEnumerator
        StartCoroutine(FailMenu());

        //pauseMenuScript.Pause();

        //stops the player from being able to press esc and unpause the game.
        //pauseMenuScript.enabled = false;
    }

    public void LevelComplete()
    {
        //if (instructions == true)
        //{
        //    instructions.SetActive(false);
        //}
        //Debug.Log("Level Complete");
        //levelCompleteUI.SetActive(true);
        //PauseMenu.GameIsPaused = true;
        //pauseMenuScript.Pause();
        //pauseMenuScript.enabled = false;

        // Starts the code of the WinMenu function found within the second Enumerator
        StartCoroutine(WinMenu());
    }

    IEnumerator FailMenu()
    {
        if (instructions == true)
        {
            instructions.SetActive(false);
        }

        // sets the fail menu UI fade to true
        failMenuFadeIn = true;

        // waits 3 seconds before executing the code below
        yield return new WaitForSeconds(3.0f);

        // runs the pause function from the pause menu script (which pauses the game)
        pauseMenuScript.Pause();

        // stops the player from being able to pause the game within the fail menu UI
        pauseMenuScript.enabled = false;
    }

    IEnumerator WinMenu()
    {
        if (instructions == true)
        {
            instructions.SetActive(false);
        }

        winMenuFadeIn = true;

        yield return new WaitForSeconds(3.0f);

        // runs the pause function from the pause menu script (which pauses the game)
        PauseMenu.GameIsPaused = true;
        pauseMenuScript.Pause();

        // stops the player from being able to pause the game within the win menu UI
        pauseMenuScript.enabled = false;
    }
}
