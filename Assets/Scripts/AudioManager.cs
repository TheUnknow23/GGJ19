using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    public GameUIManager gameover;

    public Sound[] sounds;

    // Start is called before the first frame update
    void Awake() {
        foreach(Sound s in sounds) {
            s.source = gameObject.AddComponent<AudioSource>();

            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }

    void Start() {
        Play("Theme");
    }

    void Update() {
        if(!isPlaying("Theme")) {
            gameover.GameOver();
        }
    }

    AudioSource source;

    public bool isPlaying(string name) {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        source = s.source;
        return source.isPlaying;
    }

    public void Play(string name) {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }
}
