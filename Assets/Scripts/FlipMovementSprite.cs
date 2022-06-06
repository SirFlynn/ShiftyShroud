using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipMovementSprite : MonoBehaviour
{
    public MouseController mouseController;

    Vector3 movePoint1;

    public void FlipHorizontally()
    {
        mouseController.movePoint = movePoint1;

        float movePointFloat = movePoint1;

        if (mouseController.movePoint > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, -90);
        }

        if (mouseController.horizontal < 0)
        {
            transform.eulerAngles = new Vector3(0, 0, -180);
        }

    }
}
