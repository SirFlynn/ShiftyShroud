using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameManager gameManager;

    public void Quit()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }

    public void Level1()
    {
        //SceneManager.LoadScene("Level_01");

        Debug.Log(gameManager.levelsDone);
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
