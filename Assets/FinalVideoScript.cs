using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class FinalVideoScript : MonoBehaviour
{
    private VideoPlayer videoPlayer;

    void Start(){
        videoPlayer = GetComponent<VideoPlayer>();

        videoPlayer.loopPointReached += EndVideo;
    }

    void EndVideo(VideoPlayer videoPlayerFinal){
        StartCoroutine(LoadAsynchronous(SceneManager.GetActiveScene().buildIndex-1));
    }

    IEnumerator LoadAsynchronous(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("Scenes/5 - VignettaFine");

        while (!operation.isDone)
        {
            yield return null;
        }
    }
}
