using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUIManager : MonoBehaviour
{
    //Public variables
    public GameObject[] Hearts = new GameObject [3];
    public PauseMenu PauseMenu;
    public GameObject player;
    public GameObject gameOver;
    public GameObject mainCam;
    public GameObject canvas;
    public Animator Animator;
    public bool Game_Over;
    
    [HideInInspector]
    public bool GameIsPaused;
    bool mapVisible = false;

    private int i = 0;
    private bool intargetable = false;

    public void Start()
    {
        Game_Over = false;
        Animator.ResetTrigger("Death");
        if (player == null)
        {
            Instantiate(player);
        }
        GameIsPaused = PauseMenu.GameIsPaused;

        canvas.SetActive(false);
        mainCam.SetActive(true);
    }

    public void Update()
    {
        GameIsPaused = PauseMenu.GameIsPaused;

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

    }

    public void RemoveLife()
    {
        if (!intargetable)
        {
            Animator.SetBool("damage", true);
            Animator.SetTrigger("Damage");
            Destroy(Hearts[Hearts.Length - i - 1]);
            i++;
            if (i == 3)
            {
                GameOver();
            }
            intargetable = true;
            StartCoroutine(Invulnerability());
        }
    }

    IEnumerator Invulnerability()
    {
        yield return new WaitForSeconds(3);
        intargetable = false;
        Animator.SetBool("damage", false);
    }

    public void Resume()
    {
        PauseMenu.Resume();
    }
    
    public void LoadMenu()
    {
        StartCoroutine(LoadAsynchronous(SceneManager.GetActiveScene().buildIndex-1));
        Destroy(player);
        StartCoroutine(UnloadAsynchronous(SceneManager.GetActiveScene().buildIndex));
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

    public void QuitGame()
    {
        Destroy(player);
        Application.Quit();
    }

    public void GameOver()
    {
        Game_Over = true;
        Animator.SetTrigger("Death");
        gameOver.SetActive(true);
    }
}
