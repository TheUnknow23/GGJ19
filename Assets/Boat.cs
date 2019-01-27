using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : MonoBehaviour
{
    private float time;
    private bool start=false;
    public UB.D2FogsPE d2FogsPE;
    public GameUIManager gameUIManager;

    // Start is called before the first frame update
    void Start()
    {
        time = Random.Range(10,20);
        d2FogsPE.Density = 0.0f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if ((!gameUIManager.Game_Over)&&(!start))
        {
            StartCoroutine(Wait());
            start = true;
        }
    }

    IEnumerator Wait()
    {
        Debug.Log("OK");
        yield return new WaitForSeconds(time);
        d2FogsPE.Density= 0.9f;
        yield return new WaitForSecondsRealtime(4);
        d2FogsPE.Density = 0.0f;
    }
}
