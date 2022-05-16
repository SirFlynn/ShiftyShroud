using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserParticle : MonoBehaviour
{
    [SerializeField] private float defDistanceRay = 100;
    public Transform laserFirePoint;
    public LineRenderer m_lineRenderer;
    Transform m_transform;

    public GameManager gameManager;

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
        if (Physics2D.Raycast(m_transform.position, -transform.up))
        {
            RaycastHit2D hit = Physics2D.Raycast(m_transform.position, -transform.up);
            Draw2DRay(laserFirePoint.position, hit.point);

            if (hit.transform.CompareTag("Player"))
            {
                Debug.Log("you hit me");
                gameManager.LevelFailed();
                //change sprite to deathsprite
            }
        }

        else
        {
            Draw2DRay(laserFirePoint.position, laserFirePoint.transform.up * defDistanceRay);
        }
    }

    void Draw2DRay(Vector2 startpos, Vector2 endpos)
    {
        m_lineRenderer.SetPosition(0, startpos);
        m_lineRenderer.SetPosition(1, endpos);
    }
}
