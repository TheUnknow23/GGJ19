using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallTriggerController : MonoBehaviour
{

    public GameObject trigger1;
    public GameObject trigger2;
    public GameObject player;

    private Vector2 position1;
    private Vector2 position2;
    Vector2 Position;
    private Animator playerAnimator;

    void Start()
    {
        playerAnimator = player.GetComponent<Animator>();
        position1 = trigger1.transform.position;
        Debug.Log(position1);
        position2 = trigger2.transform.position;
    }

    public void Teleport(string name)
    {
        Debug.Log(position1);
        switch (name)
        {
                case "WallTrigger1":
                    Position = position2;
                    break;
                case "WallTrigger2" :
                    Position = position1;
                    break;
        }
        Debug.Log(gameObject.name +" : "+ Position);
        playerAnimator.SetTrigger("sandDown");
        StartCoroutine(WaitAnim());
        StartCoroutine(Wait(Position));
    }

    IEnumerator Wait(Vector2 position)
    {
        yield return new WaitForSecondsRealtime(1.5f);
        player.transform.position = new Vector3(this.Position.x, this.Position.y);
        player.SetActive(true);
        playerAnimator.SetTrigger("sandUp");
        StartCoroutine(WaitUp());
    }
    
    IEnumerator WaitAnim()
    {
        yield return new WaitForSecondsRealtime(0.7f);
        player.SetActive(false);
    }
    
    IEnumerator WaitUp()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        playerAnimator.SetTrigger("idle");
    }
}
