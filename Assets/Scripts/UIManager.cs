using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject mainMenuUI;
    public GameObject levelMenuUI;
    public GameObject creditsMenuUI;
    public GameObject settingsMenuUI;

    // Start is called before the first frame update
    void Start()
    {
        mainMenuUI = GameObject.Find("MainMenuUI");
        levelMenuUI = GameObject.Find("LevelMenuUI");
        settingsMenuUI = GameObject.Find("SettingsMenuUI");
        creditsMenuUI = GameObject.Find("CreditsMenuUI");

        mainMenuUI.SetActive(true);
        levelMenuUI.SetActive(false);
        settingsMenuUI.SetActive(false);
        creditsMenuUI.SetActive(false);
    }

    public void PlayGame()
    {
        mainMenuUI.SetActive(false);
        levelMenuUI.SetActive(true);
    }

    public void Return()
    {
        mainMenuUI.SetActive(true);
        levelMenuUI.SetActive(false);
        creditsMenuUI.SetActive(false);
        settingsMenuUI.SetActive(false);
    }

    public void Settings()
    {
        mainMenuUI.SetActive(false);
        settingsMenuUI.SetActive(true);
    }

    public void Credits()
    {
        mainMenuUI.SetActive(false);
        creditsMenuUI.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Level1()
    {
        SceneManager.LoadScene("Main");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
