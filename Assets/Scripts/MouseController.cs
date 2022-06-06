using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Vector3 movePoint;

    //public GameObject endWaypoint;
    //public GameObject player;

    public FlipMovementSprite flipSprite;
    public float horizontal;
    public float vertical;

    public float duration = 4.0f;

    public LayerMask whatStopsMovement;

    public GameManager gameManager;


    void Start()
    {
        movePoint = transform.position;
    }

    /*Lerps the player to the cheese 
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
    */
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePoint, moveSpeed * Time.deltaTime);

        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        if (Vector3.Distance(transform.position, movePoint) <= .05f)
        {

            if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f)
            {
                if (!Physics2D.OverlapCircle(movePoint + new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f), .2f, whatStopsMovement))
                {
                    movePoint += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);

                    transform.eulerAngles = new Vector3(0, 0, -90);
                }
            }
            else if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f)
            {
                if (!Physics2D.OverlapCircle(movePoint + new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f), .2f, whatStopsMovement))
                {
                    movePoint += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);

                    transform.eulerAngles = new Vector3(0, -180, 0);
                }
            }
        }
    }
} 
