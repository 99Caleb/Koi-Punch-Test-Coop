using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicHigherGong : MonoBehaviour
{
    public AudioSource audioSource;
    public void OnMouseUpAsButton()
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
