using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    public GameUIManager GameUiManager;
    //public List<GameObject> Waypoints;
    public GameObject start;
    public GameObject target;
    private float speed = 1.5f;
    private float time = 0;
    
    private Rigidbody2D _rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        //Waypoints = new List<GameObject>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
        //_rigidbody2D.velocity = Vector2.left * 2f;

        // start = Waypoints[0].transform.position;
        // target = Waypoints[1].transform.position;

    }

    void Update()
    {
        time += Time.deltaTime;
        float step = speed * Time.deltaTime * Mathf.Sin(Random.Range(0.5f,1.5f));
        transform.position = Vector2.Lerp(start.transform.position, target.transform.position, speed *Mathf.Sin(time));

        if (transform.position == target.transform.position){
            transform.position = Vector2.MoveTowards(transform.position, start.transform.position, step);
        }
        if (transform.position == start.transform.position){
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, step);
        }

        // if (other.CompareTag("Waypoint"))
        // {
        //     _rigidbody2D.velocity = _rigidbody2D.velocity * -1;
        // } else if (other.CompareTag("Player"))
        // {
        //     Debug.Log("OK");
        //     GameUiManager.RemoveLife();
        // }
    }
}
