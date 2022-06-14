using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelUnlockTest2 : MonoBehaviour
{
    public void LoadNumber100()
    {
        int loadedNumber100 = PlayerPrefs.GetInt("number100");

        Debug.Log(loadedNumber100);

/*        if (loadedNumber100 == 100)
        {
            Debug.Log(loadedNumber100);
        } else
        {
            Debug.Log("The number is not 100");
        }*/
    }

    public void LoadNumber200()
    {
        int loadedNumber200 = PlayerPrefs.GetInt("number200");

        if (loadedNumber200 == 200)
        {
            Debug.Log(loadedNumber200);
        }
        else
        {
            Debug.Log("The number is not 200");
        }
    }
}
