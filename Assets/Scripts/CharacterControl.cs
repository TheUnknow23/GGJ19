using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Collider2D))]
[RequireComponent(typeof(Rigidbody2D))]

public class CharacterControl : MonoBehaviour
{

    private Rigidbody2D _rigidbody;
    public float moveSpeed = 5f;
    private float horVel;
    private float verVel;
    
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horVel = Input.GetAxis("Horizontal")*moveSpeed;
        verVel = Input.GetAxis("Vertical")*moveSpeed;
    }

    private void FixedUpdate()
    {

        _rigidbody.velocity = new Vector2(Mathf.Lerp(0, Input.GetAxis("Horizontal")*moveSpeed, 0.8f), Mathf.Lerp(0, verVel, 0.8f));
    }
}
