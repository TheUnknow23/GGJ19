using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleShooter : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public GameUIManager GameUIManager;

    private bool pause = false;

    void Start()
    {
        pause = false;
        Physics2D.IgnoreLayerCollision(8, 12);
    }

    void Update()
    {
        pause = GameUIManager.GameIsPaused;
        if (Input.GetButtonDown("Fire1")&&!pause)
        {
            ShootBubble();
        }
    }

    void ShootBubble()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
