using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save_Position : MonoBehaviour
{
    Vector3 startPosition;

    public MouseController bigMouseController;

    void Start()
    {
        startPosition = transform.position;

        bigMouseController = GetComponent<MouseController>();

        Debug.Log("Start position saved");
    }

    public void BackToPosition()
    {
        transform.position = startPosition;

        bigMouseController.movePoint = startPosition;

        Debug.Log("Returned to start position");
    }
}
