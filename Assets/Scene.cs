using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene : MonoBehaviour
{
        public void SceneLoader()
    {
        StartCoroutine(LoadAsynchronous(SceneManager.GetActiveScene().buildIndex-1));
    }
    
    IEnumerator LoadAsynchronous(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("Scenes/3 - Level");

        while (!operation.isDone)
        {
            yield return null;
        }
    }
}
