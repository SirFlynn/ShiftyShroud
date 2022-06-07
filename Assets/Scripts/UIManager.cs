using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Button level02Button, level03Button, level04Button, level05Button;
    int levelPassed;

    void Start()
    {
        levelPassed = PlayerPrefs.GetInt("LevelPassed");

        level02Button.interactable = false;
        level03Button.interactable = false;
        level04Button.interactable = false;
        level05Button.interactable = false;

        switch (levelPassed)
        {
            case 1:
                level02Button.interactable = true;
                break;
            case 2:
                level03Button.interactable = true;
                break;
            case 3:
                level04Button.interactable = true;
                break;
            case 4:
                level05Button.interactable = true;
                break;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            level02Button.interactable = false;
            level03Button.interactable = false;
            level04Button.interactable = false;
            level05Button.interactable = false;

            PlayerPrefs.DeleteAll();
        }
    }
    public void levelToLoad (int level)
    {
        SceneManager.LoadScene(level);
    }

    public void Quit()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }

/*    public void Level1()
    {
        SceneManager.LoadScene("Level_01");
    }

    public void Level2()
    {
        SceneManager.LoadScene("Level_02");
    }

    public void Level3()
    {
        SceneManager.LoadScene("Level_03");
    }

    public void Level4()
    {
        SceneManager.LoadScene("Level_04");
    }

    public void Level5()
    {
        SceneManager.LoadScene("Level_05");
    }*/

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
