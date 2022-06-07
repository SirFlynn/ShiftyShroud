using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Security_Cat : MonoBehaviour
{
    public GameManager gameManager;
    public Save_Position startPosition;
    public ControlManager manager;

    public AudioSource meow;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //Debug.Log("The security cat saw the mouse!");
            meow.Play();
            gameManager.LevelFailedCat();
        }
        
        else if (other.tag == "Crate")
        {
            //Debug.Log("The security cat saw the crate!")
            //startPosition.BackToPosition();
            other.GetComponent<Save_Position>().BackToPosition();
            meow.Play();
        }
    }
}
