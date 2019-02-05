using System.Collections;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class Underground : MonoBehaviour
{

    public GameObject Player;
    public Animator Animator;
    public GameUIManager GameUiManager;
    [HideInInspector]
    public bool underground = false;

    private CharacterControl _characterControl;
    private Rigidbody2D _rigidbody2D;
    private bool done = false;

    /*void Start()
    {
        Physics2D.IgnoreLayerCollision(9, 11);
        _characterControl = GetComponent<CharacterControl>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }


    public void GoUnderground(float hor, float ver)
    {
        int hori, vert;
        hori = (int) Mathf.Clamp(hor, -1, 1);
        vert = (int) Mathf.Clamp(ver, -1, 1);
        _characterControl.enabled = false;
        Animator.SetTrigger("Sand");
        Animator.SetBool("sand", true);
        gameObject.layer = 9;
        underground = true;
        StartCoroutine(Wait());
        if (hori > 0 && vert > 0)
        {
            _rigidbody2D.velocity= (Vector2.right+Vector2.up)*2f;
        } if (hori > 0 && vert == 0)
        {
            _rigidbody2D.velocity= (Vector2.right)*4f;  
        } else if (hori < 0 && vert > 0)
        {
            _rigidbody2D.velocity= (Vector2.left+Vector2.up)*2f;
        } else if (hori < 0 && vert == 0)
        {
            _rigidbody2D.velocity = (Vector2.left) * 4f;
        } else if (hori < 0 && vert < 0)
        {
            _rigidbody2D.velocity= (Vector2.left+Vector2.down)*2f;
        } else if (hori == 0 && vert < 0)
        {
            _rigidbody2D.velocity= (Vector2.down)*4f;
        } else if (hori > 0 && vert < 0)
        {
            _rigidbody2D.velocity= (Vector2.right+Vector2.down)*2f;
        }
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
    }*/

    void GameOver()
    {
        GameUiManager.GameOverOverlay();
    }
}
