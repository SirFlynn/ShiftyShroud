using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectController : MonoBehaviour
{
    public ControlManager manager;
    public GameObject mouse;
    private bool touchingPlayer = false;

    //private void OnTriggerEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "Player")
    //    {
    //        touchingPlayer = true;
    //        Debug.Log("bruhuhubfuibgbdfugbeyuivsed");
    //    }
    //}

    //private void OnTriggerExit2D(Collision collision)
    //{
    //    if (collision.gameObject.tag == "Player")
    //    {
    //        touchingPlayer = false;
    //    }
    //}

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
