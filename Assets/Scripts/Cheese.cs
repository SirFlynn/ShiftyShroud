using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheese : MonoBehaviour
{
    public GameManager gameManager;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            gameManager.LevelComplete();

            LevelController.instance.YouWin();
        }
    }
}
