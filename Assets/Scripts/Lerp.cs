using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour
{
    public GameObject endWaypoint;
    public GameObject player;

    public float duration = 4.0f;

    void Update()
    {
        //ensures that if duration is changed to 0 it is reset to 1 so that it does not cause error
        if (duration == 0)
            duration = 1;


        //goes from 0-durations value then repeats
        float timer = Mathf.PingPong(Time.time, duration) / duration;

        //change timer to ease the acceleration
        timer = easeInOutSine(timer);

        //Lerp position from start waypoint to end waypoint over time
        Vector3 position = Vector3.Lerp(player.transform.position, endWaypoint.transform.position, timer);

        transform.position = position;

        //used to slow down the object and make it gain speed when moving
        float easeInOutSine(float x)
        {
            return -(Mathf.Cos(Mathf.PI * x) - 1) / 2;
        }
    }
}
