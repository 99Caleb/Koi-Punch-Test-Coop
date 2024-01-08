using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicHigherGong : TopScript
{
    public AudioSource audioSource;
    public void OnMouseDown()
    {
        if (PlayerPrefs.GetFloat("MusicVolume") >= 1f)
        {
            audioSource.Play();
        }else
        {
            PlayerPrefs.SetFloat("MusicVolume", PlayerPrefs.GetFloat("MusicVolume") + .1f);
            Debug.Log(PlayerPrefs.GetFloat("MusicVolume"));
            audioSource.volume = PlayerPrefs.GetFloat("MusicVolume");
            audioSource.Play();
        }
    }
}
