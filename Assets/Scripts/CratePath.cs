using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CratePath : MonoBehaviour
{
    public GameObject test = null;

    void Start()
    {
        test = GameObject.Find("Test");

        test.SetActive(true);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            test.SetActive(false);
        }
    }
}
