using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUIManager : MonoBehaviour
{
    //Public variables
    public GameObject[] Hearts = new GameObject [3];
    public PauseMenu PauseMenu;

    //Private variables
    private List<GameObject> hearts = new List<GameObject>();
    
    private void Start()
    {
        hearts.Add(Hearts[0]);
        hearts.Add(Hearts[1]);
        hearts.Add(Hearts[2]);
    }

    public void RemoveLife()
    {
        hearts.RemoveAt(hearts.Count-1);
    }

    public void Resume()
    {
        PauseMenu.Resume();
    }
    
    public void LoadMenu()
    {
        StartCoroutine(LoadAsynchronous(SceneManager.GetActiveScene().buildIndex-1));
    }
    
    IEnumerator LoadAsynchronous(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        while (!operation.isDone)
        {
            yield return null;
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
