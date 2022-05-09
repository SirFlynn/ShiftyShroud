using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectController : MonoBehaviour
{
    public GameObject otherPlayer;
    public GameObject crate;

    void Start()
    {
        crate.GetComponent<MouseController>().enabled = false;
    }

    private void OnMouseDown()
    {
        otherPlayer.GetComponent<MouseController>().enabled = false;
        GetComponent<MouseController>().enabled = true;
    }
}
