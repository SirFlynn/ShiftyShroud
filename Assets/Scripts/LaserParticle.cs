using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserParticle : MonoBehaviour
{
    [SerializeField] private float defDistanceRay = 100;
    public Transform laserFireStart;
    public Transform laserFireEnd;
    public LineRenderer m_lineRenderer;
    Transform m_transform;

    public GameManager gameManager;


    //will look for layer 10
    private int layerMask = 1<<10;

    private void Awake()
    {
        m_transform = GetComponent<Transform>();
    }

    private void Update()
    {
        ShootLaser();
    }

    void ShootLaser()
    {
        //changes the sorting layer for the line renderer. 
        m_lineRenderer.sortingLayerName = "Foreground";
        //Shoots a laser in a direction and stops if it hits a collider on the layer defined in layerMask. 
        if (Physics2D.Raycast(m_transform.position, -transform.up, 10, layerMask))
        {
            RaycastHit2D hit = Physics2D.Raycast(m_transform.position, -transform.up, 10, layerMask);
            Draw2DRay(laserFireStart.position, hit.point);

            //checks if the object the raycast hits is the player and if it is triggers level fail.
            if (hit.transform.CompareTag("Player"))
            {
                //Debug.Log("you hit me");
                gameManager.LevelFailed();
                //change sprite to deathsprite
            }
        }

        else
        {
            Draw2DRay(laserFireStart.position, laserFireEnd.position * defDistanceRay);
        }
    }

    void Draw2DRay(Vector2 startpos, Vector2 endpos)
    {
        m_lineRenderer.SetPosition(0, startpos);
        m_lineRenderer.SetPosition(1, endpos);
    }
}
