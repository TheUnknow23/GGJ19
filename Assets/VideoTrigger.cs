using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoTrigger : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    public void OnTriggerEnter2D(Collider2D other) {
        videoPlayer.Play();
    }
}
