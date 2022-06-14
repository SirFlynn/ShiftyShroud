using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelMenu : MonoBehaviour
{
    public Button level02, level03, level04, level05;
    void Start()
    {
        level02.interactable = false;
        level03.interactable = false;
        level04.interactable = false;
        level05.interactable = false;
    }
    void Update()
    {
        int levelsComplete = PlayerPrefs.GetInt("LevelsComplete");

        if (Input.GetKeyDown("r"))
        {
            PlayerPrefs.DeleteKey("LevelsComplete");
        }

        if (levelsComplete >= 1)
        {
            level02.interactable = true;
        } else
        {
            level02.interactable = false;
        }

        if (levelsComplete >= 2)
        {
            level03.interactable = true;
        } else
        {
            level03.interactable = false;
        }

        if (levelsComplete >= 3)
        {
            level04.interactable = true;
        } else
        {
            level04.interactable = false;
        }

        if (levelsComplete >= 4)
        {
            level05.interactable = true;
        } else
        {
            level05.interactable = false;
        }

    }

    public void CurrentLevels()
    {
        int levelsComplete = PlayerPrefs.GetInt("LevelsComplete");

        Debug.Log(levelsComplete);
    }

    public void ClearLevels()
    {
        PlayerPrefs.DeleteKey("LevelsComplete");
    }
    public void Add()
    {
        int levelsComplete = PlayerPrefs.GetInt("LevelsComplete");

        PlayerPrefs.SetInt("LevelsComplete", PlayerPrefs.GetInt("LevelsComplete") + 1);

        Debug.Log(levelsComplete);
    }

    public void Take()
    {
        PlayerPrefs.SetInt("LevelsComplete", PlayerPrefs.GetInt("LevelsComplete") - 1);
    }

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

        if (levelsComplete >= 1)
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

        if (levelsComplete >= 2)
        {
            SceneManager.LoadScene("Level_03");
        }
        else
        {
            Debug.Log("Player hasn't completed level 3 yet.");
            level03.interactable = false;
        }
    }
    public void Level4()
    {
        int levelsComplete = PlayerPrefs.GetInt("LevelsComplete");

        if (levelsComplete >= 3)
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

        if (levelsComplete >= 4)
        {
            SceneManager.LoadScene("Level_05");
        }
        else
        {
            Debug.Log("Player hasn't completed level 5 yet.");
        }
    }
}
