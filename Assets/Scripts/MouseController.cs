using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Vector3 movePoint;

    public float duration = 4.0f;

    public LayerMask whatStopsMovement;

    public GameManager gameManager;

    float inputHorizontal;
    float inputVertical;

    public Transform mouseSprite;

    void Start()
    {
        movePoint = transform.position;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePoint, moveSpeed * Time.deltaTime);
        
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical");


        if (Vector3.Distance(transform.position, movePoint) <= .05f)
        {
            //controls horizontal movement
            if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f)
            {
                //stops movement if collides with whatStopsMovement
                if (!Physics2D.OverlapCircle(movePoint + new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f), .2f, whatStopsMovement))
                {
                    //moves the movepoint to the space specified with WASD then moves everything to that movepoint
                    movePoint += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);

                    //Changes the rotation transform of the mouse sprite to face to the right 
                    if(inputHorizontal >0)
                    {
                        mouseSprite.eulerAngles = new Vector3(0, 0, -90);
                    }

                    //Changes the rotation transform of the mouse sprite to face to the left 

                    if (inputHorizontal < 0)
                    {
                        mouseSprite.eulerAngles = new Vector3(0, 0, 90);
                    }
                }
            }

            //controls vertical movement
            else if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f)
            {
                if (!Physics2D.OverlapCircle(movePoint + new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f), .2f, whatStopsMovement))
                {
                    movePoint += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);

                    //Changes the rotation transform of the mouse sprite to face up
                    
                    if (inputVertical > 0)
                    {
                        mouseSprite.eulerAngles = new Vector3(0, 0, 0);
                    }

                    //Changes the rotation transform of the mouse sprite to face down

                    if (inputVertical < 0)
                    {
                        mouseSprite.eulerAngles = new Vector3(0, 0, -180);
                    }
                }
            }
        }
    }
} 
