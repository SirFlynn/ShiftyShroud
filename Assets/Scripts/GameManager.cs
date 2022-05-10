using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject levelFailedUI;

    public void LevelFailed()
    {
        Debug.Log("Level Failed");
        levelFailedUI.SetActive(true);
    }
}
