using System.Collections;
using EZCameraShake;
using UB;
using UnityEngine;

public class Boat : MonoBehaviour
{
    private float time;
    private bool start=false;
    private UB.D2FogsPE d2FogsPE;
    private Camera mainCamera;
    private float density;
    public GameUIManager gameUIManager;

    void Start()
    {
        mainCamera = GetComponent<Camera>();
        d2FogsPE = GetComponent<D2FogsPE>();
        d2FogsPE.Density = density = 0.0f;
    }

    void FixedUpdate()
    {
        if ((!gameUIManager.Game_Over)&&(!start))
        {
            time = Random.Range(15,45);
            StartCoroutine(Wait());
            start = true;
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(time);
        //DisplayAlert();
        yield return new WaitForSecondsRealtime(2);
        //HideAlert();
        //FindObjectOfType<AudioManager>().Play();
        while (density < 1.46f)
        {
            d2FogsPE.Density = density += 0.2f;
            yield return new WaitForSecondsRealtime(0.2f);
        }
        yield return new WaitForSecondsRealtime(4);
        while (density > 0)
        {
            d2FogsPE.Density = density -= 0.2f;
            yield return new WaitForSecondsRealtime(0.2f);
        }
        d2FogsPE.Density = 0.0f;
        start = false;
    }
}
