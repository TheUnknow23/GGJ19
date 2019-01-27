using System.Collections;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class Underground : MonoBehaviour
{

    public GameObject Player;
    public Animator Animator;
    [HideInInspector]
    public bool underground = false;

    private CharacterControl _characterControl;
    private Rigidbody2D _rigidbody2D;
    private bool done = false;

    void Start()
    {
        Physics2D.IgnoreLayerCollision(9, 11);
        _characterControl = GetComponent<CharacterControl>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }


    public void GoUnderground(float hor, float ver)
    {
        int hori, vert;
        hori = (int) Mathf.Ceil(hor);
        vert = (int) Mathf.Ceil(ver);
        _characterControl.enabled = false;
        Animator.SetTrigger("Sand");
        Animator.SetBool("sand", true);
        gameObject.layer = 9;
        underground = true;
        StartCoroutine(Wait());
        StartCoroutine(Move(hori, vert));
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3);
        done = true;
        underground = false;
        gameObject.layer = 8;
        Animator.ResetTrigger("Sand");
        Animator.SetBool("sand", false);
        _characterControl.enabled = true;
    }

    IEnumerator Move(int hori, int vert)
    {
        if (hori > 0 && vert > 0)
        {
            while (!done)
            {
                _rigidbody2D.velocity= (Vector2.right+Vector2.up)*2f;  /*new Vector2(Mathf.Lerp(0, hori*5f, 0.8f), Mathf.Lerp(0, vert*5f, 0.8f));*/
                yield return new WaitForSeconds(0.1f);
            }
        } else if (hori > 0 && vert == 0)
        {
            while (!done)
            {
                _rigidbody2D.velocity= (Vector2.right)*4f;  /*new Vector2(Mathf.Lerp(0, hori*5f, 0.8f), Mathf.Lerp(0, vert*5f, 0.8f));*/
                yield return new WaitForSeconds(0.1f);
            }
        } else if (hori < 0 && vert > 0)
        {
            while (!done)
            {
                _rigidbody2D.velocity= (Vector2.left+Vector2.up)*2f;  /*new Vector2(Mathf.Lerp(0, hori*5f, 0.8f), Mathf.Lerp(0, vert*5f, 0.8f));*/
                yield return new WaitForSeconds(0.1f);
            }
           
        } else if (hori < 0 && vert == 0)
        {
            while (!done)
            {
                _rigidbody2D.velocity= (Vector2.left)*4f;  /*new Vector2(Mathf.Lerp(0, hori*5f, 0.8f), Mathf.Lerp(0, vert*5f, 0.8f));*/
                yield return new WaitForSeconds(0.1f);
            }
        } else if (hori < 0 && vert < 0)
        {
            while (!done)
            {
                _rigidbody2D.velocity= (Vector2.left+Vector2.down)*2f;  /*new Vector2(Mathf.Lerp(0, hori*5f, 0.8f), Mathf.Lerp(0, vert*5f, 0.8f));*/
                yield return new WaitForSeconds(0.1f);
            }
        } else if (hori == 0 && vert < 0)
        {
            while (!done)
            {
                _rigidbody2D.velocity= (Vector2.down)*4f;  /*new Vector2(Mathf.Lerp(0, hori*5f, 0.8f), Mathf.Lerp(0, vert*5f, 0.8f));*/
                yield return new WaitForSeconds(0.1f);
            }
        } else if (hori > 0 && vert < 0)
        {
            while (!done)
            {
                _rigidbody2D.velocity= (Vector2.right+Vector2.down)*2f;  /*new Vector2(Mathf.Lerp(0, hori*5f, 0.8f), Mathf.Lerp(0, vert*5f, 0.8f));*/
                yield return new WaitForSeconds(0.1f);
            }
        }
    }
}
