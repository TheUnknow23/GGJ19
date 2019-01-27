using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGUIManager : MonoBehaviour
{
    //Public variables
    public Animator Animator;
    
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

    IEnumerator LoadAsynchronous(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        while (!operation.isDone)
        {
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
