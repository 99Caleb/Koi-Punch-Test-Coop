using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SettingsMusicManager : MonoBehaviour
{
   public GameObject musicSlider;
   private float volumeScale;
   
   private void Start()
   {
      PlayerPrefs.SetFloat("MusicVolume", 1);
      
      /*if (PlayerPrefs.HasKey("MusicVolume"))
      {
         //LoadVolume();
      }
      else
      {
         SetMusicVolume();
      }*/
   }

   private void Update()
   {
      volumeScale = PlayerPrefs.GetFloat("MusicVolume") * .45f;
      musicSlider.transform.localScale = new Vector3(volumeScale, .05f, .1f);
   }

   public void SetMusicVolume()
   {
      PlayerPrefs.SetFloat("MusicVolume", 1);
   }

   /*private void LoadVolume()
   {
      musicSlider.transform.localScale = new Vector3(volumeScale, .05f, .1f);
      
      SetMusicVolume();
   }*/
}
