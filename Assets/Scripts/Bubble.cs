using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    public float speed = 25f;
    public Rigidbody2D Rigidbody2D;
    private AlgaeBehaviour algae;
    
    // Start is called before the first frame update
    void Start()
    {
        Physics2D.IgnoreLayerCollision(8, 12);
        Rigidbody2D.velocity = transform.up * speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.tag);
        if (!other.CompareTag("Player"))
        {
            if (other.CompareTag("Algae"))
            {
                algae = other.GetComponent<AlgaeBehaviour>();
                algae.life--;
            }
            Destroy(gameObject);
        }
    }
}
