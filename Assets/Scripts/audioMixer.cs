using UnityEngine.Audio;
using UnityEngine;
[RequireComponent(typeof(Collider2D))]
[RequireComponent(typeof(Rigidbody2D))]

public class audioMixer : MonoBehaviour
{

    AudioSource source;

    private Rigidbody2D _rigidbody;

    void Start()
    {
        //Fetch the Rigidbody2D from the GameObject
        _rigidbody = GetComponent<Rigidbody2D>();
        //Fetch the AudioSource from the GameObject
        source = GetComponent<AudioSource>();
        //Play the audio you attach to the AudioSource component
        source.Play();
        source.mute = false;
    }

    private void FixedUpdate()
    {
        if(_rigidbody.velocity[0] != 0 || _rigidbody.velocity[1] != 0) 
        {
            source.mute = false;
        } else {
            source.mute = true;
        }
    }
}