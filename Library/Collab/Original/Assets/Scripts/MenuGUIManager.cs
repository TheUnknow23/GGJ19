using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class MenuGUIManager : MonoBehaviour
{
    //Public variables
    public Animator Animator;

    public GameObject loadingScreen;

    public GameObject videoScreen;
    public GameObject artbook;
    private VideoPlayer videoPlayer;


    public Slider slider;
    public GameObject[] bolle;


    //Methods
    public void Start()
    {
        Animator.SetTrigger("Return");
    }

    public void LoadGame()
    {
        StartCoroutine(LoadAsynchronous(SceneManager.GetActiveScene().buildIndex+1));
        //StartCoroutine(UnloadAsynchronous(SceneManager.GetActiveScene().buildIndex));
    }

    public void LoadVideo() {
        videoScreen.SetActive(true);
        artbook.SetActive(true);
        videoPlayer = artbook.GetComponent<VideoPlayer>();
        videoPlayer.Play();
    }

    IEnumerator LoadAsynchronous(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("Scenes/2 - VignettaInizio");

        loadingScreen.SetActive(true);

        for (int i = 0; i < bolle.Length; i++)
        {
            bolle[i].SetActive(false);
        } 

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            yield return null;
        }
    }
    IEnumerator UnloadAsynchronous(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.UnloadSceneAsync(sceneIndex);

        while (!operation.isDone)
        {
            yield return null;
        }
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}
