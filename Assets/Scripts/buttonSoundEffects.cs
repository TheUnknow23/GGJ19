using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonSoundEffects : MonoBehaviour
{
    public AudioSource soundEffects;
    public AudioClip hoverSoundEffect;
    public AudioClip clickSoundEffect;

    public void hoverSound() {
        soundEffects.PlayOneShot(hoverSoundEffect);
    }

    public void clickSound() {
        soundEffects.PlayOneShot(clickSoundEffect);
    }
}
