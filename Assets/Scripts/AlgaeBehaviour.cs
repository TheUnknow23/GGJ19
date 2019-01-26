using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlgaeBehaviour : MonoBehaviour
{

    public int life = 4;

    void Update()
    {
        if (life == 0)
        {
            Destroy(gameObject);
        }
    }
}
