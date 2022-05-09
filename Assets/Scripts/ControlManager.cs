using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlManager : MonoBehaviour
{
    public GameObject[] Players;

    [SerializeField]
    GameObject CurrentPlayer;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i < Players.Length; i++)
        {
            Players[i].GetComponent<MouseController>().enabled = false;
        }

        CurrentPlayer = Players[0];
    }

    // Update is called once per frame
    public void ChangePlayer(GameObject player)
    {
        CurrentPlayer.GetComponent<MouseController>().enabled = false;
        CurrentPlayer = player;
    }
}
