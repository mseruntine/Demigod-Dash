using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{

    public AudioSource soundPlayer;
    public void PlayThisSoundEffect() {

        soundPlayer.Play();

    }

    // Change volume of game
    [SerializeField] Slider volumeSlider;
    public void ChangeVolume() {

        AudioListener.volume = volumeSlider.value;

    }
}
