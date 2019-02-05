using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shellBubble : MonoBehaviour
{
    public GameObject bubble; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("k")) {
            bubble.SetActive(true);

        }
        else {
            bubble.SetActive(false);
        }
    }
}
