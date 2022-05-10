using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CratePath : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Crate")
        {
            gameObject.SetActive(false);
        }
    }

    /*    // Declare the key and pickup tooltip objects so we can set them in the inspector.
        public GameObject emptyPath = null;

        // Does everything within this function on startup of the game
        void Start()
        {
            emptyPath = GameObject.Find("EmptyPath");                                           // Declaring the game object "Key" for later use.
        }

        // OnTriggerEnter of the KEY object
        void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Crate")                                              // If the player enters the trigger field of the key object, do the below actions.
            {
                emptyPath.SetActive(false);                                      // Simply shows the pickup tooltip when the player is near the key (Press E Key to Pick Up).
                Debug.Log("Test");
            }
        }
        void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.tag == "Crate")                                              // If the player enters the trigger field of the key object, do the below actions.
            {
                emptyPath.SetActive(true);                                      // Simply shows the pickup tooltip when the player is near the key (Press E Key to Pick Up).
                Debug.Log("Test2");
            }
        }*/
}
