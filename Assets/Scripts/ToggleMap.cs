using UnityEngine;
using System.Collections;
using EZCameraShake;

public class ToggleMap : MonoBehaviour {
    public GameObject mainCam;
    public GameObject canvas;

    bool mapVisible = false;
    float x;
    float y;

    // Use this for initialization
    void Start () {
        canvas.SetActive(false);
        mainCam.SetActive(true);

    }
    
    // Update is called once per frame
    void Update () {
        
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (mapVisible == true) {
                canvas.SetActive(false);
                mainCam.SetActive(true);
                mapVisible = false;
            }
            else {
                canvas.SetActive(true);
                mainCam.SetActive(false);
                mapVisible = true;
            }
        }
        //if (Input.GetMouseButtonDown(0)) {
        //    CameraShaker.Instance.ShakeOnce(1.3f, 20f, 3f, 2f);
        //}
    }
}