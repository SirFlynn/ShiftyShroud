using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

    //public void LevelFailed()
    //{
        //laserZap.Play();

        //if(instructions == true)
        //{
         //   instructions.SetActive(false);
        //}

        //waits for one second and then runs the LevelFailUI public void code
        //Invoke("LevelFailUI", TimeUntilEnd);

        //Disables the laser and mouse particle scripts so that the player cannot move and the laser does not continue to trigger the LevelFailed public void. 
       // ToggleLaserScript(false);
        //mouseControllerScript.enabled = false;
    //}

    public void LevelFailedCat()
    {
        //waits for one second and then runs the LevelFailUI public void code
        //Invoke("LevelFailUI", TimeUntilEnd);

        //Disables the laser and mouse particle scripts so that the player cannot move and the laser does not continue to trigger the LevelFailed public void. 
        //ToggleLaserScript(false);
        //mouseControllerScript.enabled = false;
        StartCoroutine(FailCatMenu());
    }

    public void LevelFailed()
    {
        StartCoroutine(FailMenu());
    }

    public void LevelComplete()
    {
        StartCoroutine(WinMenu());
    }

    IEnumerator FailCatMenu()
    {

        if (instructions == true)
        {
            instructions.SetActive(false);
        }

        // sets the fail menu UI fade to true
        failMenuFadeIn = true;

        mouseControllerScript.enabled = false;

        // waits 3 seconds before executing the code below
        yield return new WaitForSeconds(3.0f);

        // runs the pause function from the pause menu script (which pauses the game)
        pauseMenuScript.Pause();

        // stops the player from being able to pause the game within the fail menu UI
        pauseMenuScript.enabled = false;
    }

    IEnumerator FailMenu()
    {
        laserZap.Play();

        ToggleLaserScript(false);

        if (instructions == true)
        {
            instructions.SetActive(false);
        }

        // sets the fail menu UI fade to true
        failMenuFadeIn = true;

        mouseControllerScript.enabled = false;

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

        int currentScene = SceneManager.GetActiveScene().buildIndex;

        int levelsComplete = PlayerPrefs.GetInt("LevelsComplete");

        if (currentScene == 1)
        {
            //PlayerPrefs.SetInt("LevelsComplete", 1);

            if (levelsComplete < 1)
            {
                PlayerPrefs.SetInt("LevelsComplete", 1);
            }
        }

        if (currentScene == 2)
        {
            //PlayerPrefs.SetInt("LevelsComplete", 2);

            if (levelsComplete < 2)
            {
                PlayerPrefs.SetInt("LevelsComplete", 2);
            }
        }

        if (currentScene == 3)
        {
            //PlayerPrefs.SetInt("LevelsComplete", 3);

            if (levelsComplete < 3)
            {
                PlayerPrefs.SetInt("LevelsComplete", 3);
            }
        }

        if (currentScene == 4)
        {
            //PlayerPrefs.SetInt("LevelsComplete", 4);

            if (levelsComplete < 4)
            {
                PlayerPrefs.SetInt("LevelsComplete", 4);
            }
        }

        //PlayerPrefs.SetInt("LevelsComplete", PlayerPrefs.GetInt("LevelsComplete") + 1);

        winMenuFadeIn = true;

        //disables mouse controller
        mouseControllerScript.enabled = false;

        yield return new WaitForSeconds(3.0f);

        // runs the pause function from the pause menu script (which pauses the game)
        PauseMenu.GameIsPaused = true;
        pauseMenuScript.Pause();

        // stops the player from being able to pause the game within the win menu UI
        pauseMenuScript.enabled = false;
    }
}
