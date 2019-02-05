using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    public GameObject player;
    
    // Start is called before the first frame update
    void Awake()
    {
        Instantiate(player, new Vector3(0.7f, -2.5f, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
