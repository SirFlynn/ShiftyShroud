using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectController : MonoBehaviour
{
    public ControlManager manager;
    public GameObject mouse;
    private bool touchingPlayer = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            touchingPlayer = true;
            Debug.Log("Player is on big mouse");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            touchingPlayer = false;
            Debug.Log("Player is not on big mouse");
        }
    }

    private void Update()
    {
        if (touchingPlayer == true && GetComponent<MouseController>().enabled == true)
        {
            manager.ChangePlayer(mouse.gameObject);
            GetComponent<MouseController>().enabled = false;
        }
    }

    private void OnMouseDown()
    {
        if (touchingPlayer == false)
        {
            manager.ChangePlayer(this.gameObject);
            GetComponent<MouseController>().enabled = true;
        }
    }
}
