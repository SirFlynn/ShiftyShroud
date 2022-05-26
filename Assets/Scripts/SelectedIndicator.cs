using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedIndicator : MonoBehaviour
{
    public GameObject Selected;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<MouseController>().enabled == true)
        {
            Selected.GetComponent<SpriteRenderer>().enabled = true;
        }
        else
        {
            Selected.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
