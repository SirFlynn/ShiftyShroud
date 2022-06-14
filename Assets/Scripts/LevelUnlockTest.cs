using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelUnlockTest : MonoBehaviour
{
    public void Save100()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;

        PlayerPrefs.SetInt("number100", PlayerPrefs.GetInt("number100") + 1);

        Debug.Log("Saved");

        Debug.Log(currentScene);
    }
    public void Save200()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("number200", 200);

        Debug.Log("Saved number 200");

        if (currentScene == 2)
        {
            Debug.Log("Scene 2");
        } else
        {
            Debug.Log("This is not scene 2");
        }
    }
}
