using System.Collections;
using UnityEngine;

public class Tutorial : MonoBehaviour
{

    public CharacterControl player;
    public GameObject[] components;

    private float time;
    private bool Continue;
    
    // Start is called before the first frame update
    void Start()
    {
        time=Time.timeSinceLevelLoad;
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (player.isMoving()&&(Time.timeSinceLevelLoad-time >= 5)&& components[0].activeSelf)
        {
            components[0].SetActive(false);
            StartCoroutine(wait());
        }
    }

    IEnumerator wait()
    {
        yield return new WaitForSecondsRealtime(2);
        components[1].SetActive(true);
    }
    
    
}
