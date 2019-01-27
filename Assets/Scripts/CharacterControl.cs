using UnityEngine;
[RequireComponent(typeof(Collider2D))]
[RequireComponent(typeof(Rigidbody2D))]

public class CharacterControl : MonoBehaviour
{

    private Rigidbody2D _rigidbody;
    public Animator _animator;
    public SpriteRenderer _sr;
    public float moveSpeed = 5f;
    public Underground _underground;
    
    private float horizontal;
    private float vertical;
    

    private bool isFlipped;
    
    // Start is called before the first frame update
    void Start()
    {

        isFlipped = false;
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _sr = GetComponent<SpriteRenderer>();
        _underground = GetComponent<Underground>();
    }

    private void FixedUpdate()
    {

        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Space) && !_underground.underground)
        {
            _underground.GoUnderground(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        }
        

        _rigidbody.velocity = new Vector2(Mathf.Lerp(0, horizontal*moveSpeed, 0.8f), Mathf.Lerp(0, vertical*moveSpeed, 0.8f));

        _animator.SetFloat("horizontal", _rigidbody.velocity.x);
        _animator.SetFloat("vertical", _rigidbody.velocity.y);
    }




}
