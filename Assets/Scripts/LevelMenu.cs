using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    public void Level1()
    {
        int levelsComplete = PlayerPrefs.GetInt("LevelsComplete");

        if (levelsComplete == 0)
        {
            SceneManager.LoadScene("Level_01");
        } else
        {
            Debug.Log("Player hasn't completed level 1 yet.");
        }
    }
    public void Level2()
    {
        int levelsComplete = PlayerPrefs.GetInt("LevelsComplete");

        if (levelsComplete == 1)
        {
            SceneManager.LoadScene("Level_02");
        }
        else
        {
            Debug.Log("Player hasn't completed level 2 yet.");
        }
    }
    public void Level3()
    {
        int levelsComplete = PlayerPrefs.GetInt("LevelsComplete");

        if (levelsComplete == 2)
        {
            SceneManager.LoadScene("Level_03");
        }
        else
        {
            Debug.Log("Player hasn't completed level 3 yet.");
        }
    }
    public void Level4()
    {
        int levelsComplete = PlayerPrefs.GetInt("LevelsComplete");

        if (levelsComplete == 3)
        {
            SceneManager.LoadScene("Level_04");
        }
        else
        {
            Debug.Log("Player hasn't completed level 4 yet.");
        }
    }
    public void Level5()
    {
        int levelsComplete = PlayerPrefs.GetInt("LevelsComplete");

        if (levelsComplete == 4)
        {
            SceneManager.LoadScene("Level_05");
        }
        else
        {
            Debug.Log("Player hasn't completed level 5 yet.");
        }
    }
}
