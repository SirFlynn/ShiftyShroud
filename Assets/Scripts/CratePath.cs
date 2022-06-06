using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CratePath : MonoBehaviour
{
    //allows the mouse to walk onto the big mouse
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Crate")
        {
            gameObject.layer = 0;
            //Debug.Log("Default Layer");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Crate")
        {
            gameObject.layer = 8;
            //Debug.Log("Edge layer");
        }
    }
}
