using UnityEngine;

public class BubbleShooter : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public GameUIManager GameUIManager;
    public Underground Underground;

    private bool pause = false;

    void Start()
    {
        pause = false;
        Physics2D.IgnoreLayerCollision(8, 12);
    }

    void Update()
    {
        pause = GameUIManager.GameIsPaused;
        if (Input.GetButtonDown("Fire1")&&!pause&&!Underground.underground)
        {
            ShootBubble();
            FindObjectOfType<AudioManager>().Play("Bubble");
        }
    }

    void ShootBubble()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
