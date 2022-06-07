using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public static LevelController instance = null;
    public GameManager gameManager;
    int sceneIndex, levelPassed;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        levelPassed = PlayerPrefs.GetInt("LevelPassed");
    }

    // Update is called once per frame
    public void YouWin()
    {
        if (sceneIndex == 5)
            Invoke("LoadLevelComplete", 1f);
        else
        {
            if (levelPassed < sceneIndex)
                PlayerPrefs.SetInt("LevelPassed", sceneIndex);
            Invoke("LoadLevelComplete", 1f);
        }
    }

    public void LoadLevelComplete()
    {
        gameManager.LevelComplete();
    }
}
