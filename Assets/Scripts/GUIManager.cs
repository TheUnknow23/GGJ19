using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour
{
    //Public variables
    
    
    //Methods
    public void LoadGame()
    {
        StartCoroutine(LoadAsynchronous(SceneManager.GetActiveScene().buildIndex+1));
    }

    IEnumerator LoadAsynchronous(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

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
