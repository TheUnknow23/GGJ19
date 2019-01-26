using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    public GameUIManager GameUiManager;
    public List<GameObject> Waypoints = new List<GameObject>();
    
    private Rigidbody2D _rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _rigidbody2D.velocity = Vector2.left * 2f;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Waypoint"))
        {
            _rigidbody2D.velocity = _rigidbody2D.velocity * -1;
        } else if (other.CompareTag("Player"))
        {
            GameUiManager.RemoveLife();
        }
    }
}
