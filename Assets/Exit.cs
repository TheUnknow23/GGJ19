﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    
    public GameObject player;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        StaticDataHolder.playerPosition.Set(player.transform.position.x, player.transform.position.y, player.transform.position.z);
        StartCoroutine(LoadAsynchronous(SceneManager.GetActiveScene().buildIndex+1));
        Destroy(player);
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