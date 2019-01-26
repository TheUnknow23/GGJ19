using System.Collections;
using UnityEngine;

public class Underground : MonoBehaviour
{
    public SpriteRenderer SpriteRenderer;

    private Sprite sprite;
    private Sprite spriteOld;
    [HideInInspector]
    public bool underground;

    void Start()
    {
        Physics2D.IgnoreLayerCollision(9, 11);
        SpriteRenderer = GetComponent<SpriteRenderer>();
        spriteOld = SpriteRenderer.sprite;
        sprite = Resources.Load<Sprite>("star");
        Debug.Log(sprite);

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.layer = 9;
            SpriteRenderer.sprite = sprite;
            underground = true;
            StartCoroutine(Wait());
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3);
        underground = false;
        gameObject.layer = 0;
        Debug.Log(gameObject.layer);
        SpriteRenderer.sprite = spriteOld;
    }
}
