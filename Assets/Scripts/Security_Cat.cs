using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Security_Cat : MonoBehaviour
{
    public GameManager gameManager;
    public Save_Position startPosition;
    public ControlManager manager;

    public AudioSource meow;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Debug.Log("The security cat saw the mouse!");
            gameManager.LevelFailed();
        }
        
        else if (collision.gameObject.tag == "Crate")
        {
            //Debug.Log("The security cat saw the crate!")
            //startPosition.BackToPosition();
            collision.GetComponent<Save_Position>().BackToPosition();
            meow.Play();
        }
    }
}
