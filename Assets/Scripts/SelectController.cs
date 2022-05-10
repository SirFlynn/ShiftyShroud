using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectController : MonoBehaviour
{
    public ControlManager manager;

    private void OnMouseDown()
    {
        manager.ChangePlayer(this.gameObject);
        GetComponent<MouseController>().enabled = true;
    }
}
