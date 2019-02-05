using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shellBehaviour : MonoBehaviour
{
    private BoxCollider2D boxCollider;
    private Animator animator;
    private PolygonCollider2D poly;

    public GameObject bubbleAnimator;

    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        poly = GetComponent<PolygonCollider2D>();
        animator = GetComponent<Animator>();
        bubbleAnimator.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        //print(boxCollider);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.gameObject.name + " : " + this.gameObject.name + " : " + Time.time);
        animator.SetBool("isOpen", true);
        bubbleAnimator.SetActive(false);
        poly.isTrigger = true;

    }

    void OnTriggerExit2D(Collider2D col)
    {
        Debug.Log(col.gameObject.name + " : " + this.gameObject.name + " : " + Time.time);
        animator.SetBool("isOpen", false);
        bubbleAnimator.SetActive(false);
        poly.isTrigger = false;
    }
}
