using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowPlayer : MonoBehaviour
{

    public bool bounds;
    public Vector3 minCamPos;
    public Vector3 maxCamPos;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(bounds) {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, minCamPos.x, maxCamPos.x),
            Mathf.Clamp(transform.position.y, minCamPos.y, maxCamPos.y), transform.position.z);
        }
        else
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);


    }
}
