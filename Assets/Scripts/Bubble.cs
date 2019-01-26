using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    public float speed = 25f;
    public Rigidbody2D Rigidbody2D;
    
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D.velocity = transform.up * speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.tag);
        if (!other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
