using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SecretTransport : MonoBehaviour
{
    public GameObject player;
   
    private void OnTriggerEnter2D(Collider2D other)
    {
        StaticDataHolder.playerPosition.Set(player.transform.position.x, player.transform.position.y, player.transform.position.z);
        StartCoroutine(LoadAsynchronous(SceneManager.GetActiveScene().buildIndex+1));
        StaticDataHolder.SecretRoom = true;
        Destroy(player);
    }
    
    IEnumerator LoadAsynchronous(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("Scenes/4 - SecretRoom");

        while (!operation.isDone)
        {
            yield return null;
        }
    }
}
