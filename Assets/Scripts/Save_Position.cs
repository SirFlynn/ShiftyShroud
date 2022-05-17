using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save_Position : MonoBehaviour
{
    Vector3 startPosition;

    public MouseController mouseController;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;

        mouseController = GetComponent<MouseController>();

        Debug.Log("Start position saved");
    }

    public void BackToPosition()
    {
        transform.position = startPosition;

        mouseController.movePoint = startPosition;

        Debug.Log("Returned to start position");
    }
}
