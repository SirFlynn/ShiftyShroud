using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save_Position : MonoBehaviour
{
    Vector3 startPosition;

    Rigidbody2D rigidBody2D;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;

        Debug.Log("Start position saved");
    }

    public void BackToPosition()
    {
        transform.position = startPosition;

        rigidBody2D.velocity = Vector3.zero;

        Debug.Log("Returned to start position");
    }
}
