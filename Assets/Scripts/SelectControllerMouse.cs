using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectControllerMouse : MonoBehaviour
{
    public ControlManager manager;
    public GameObject mouse;

    private void OnMouseDown()
    {
        manager.ChangePlayer(mouse.gameObject);
        mouse.GetComponent<MouseController>().enabled = true;
        Debug.Log("Mouse selected");
    }
}
