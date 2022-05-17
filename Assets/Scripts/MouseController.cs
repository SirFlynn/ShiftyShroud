using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Vector3 movePoint;
    private bool moving = false;
    public GameObject endWaypoint;
    public GameObject player;

    public float duration = 4.0f;

    public LayerMask whatStopsMovement;
    public LayerMask whatAllowsMovement;

    public GameManager gameManager;

    void Start()
    {
        movePoint = transform.position;
    }

    //Lerps the player to the cheese 
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Cheese")
        {
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

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePoint, moveSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, movePoint) <= .05f)
        {

            if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f)
            {
                if (!Physics2D.OverlapCircle(movePoint + new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f), .2f, whatStopsMovement))
                {
                    movePoint += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                    moving = true;

                    Debug.Log("Moving");
                }
            } else if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f)
            {
                if (!Physics2D.OverlapCircle(movePoint + new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f), .2f, whatStopsMovement))
                {
                    movePoint += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
                    moving = true;

                    Debug.Log("Moving");
                } 
            } else
            {
                moving = false;
            }
        } 
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Camera")
        {
            if(gameObject.tag == "Player")
            {
                //Send Mouse back to starting position
                gameManager.LevelFailed();
            }
            else if (gameObject.tag == "MoveableCrate" && moving == true)
            {
                //Send crate back to starting position
            }
        }
    }
}
