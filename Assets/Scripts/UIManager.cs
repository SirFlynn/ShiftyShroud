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
    }

    void Update()
    {
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

    public void Level1()
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
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
