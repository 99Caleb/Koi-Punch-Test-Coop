using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SettingsMusicManager : MonoBehaviour
{
   public GameObject musicSlider;
   
   private void Start()
   {
      if (PlayerPrefs.HasKey("MusicVolume"))
      {
         LoadVolume();
      }
      else
      {
         SetMusicVolume();
      }
   }

   public void SetMusicVolume()
   {
      PlayerPrefs.SetFloat("MusicVolume", 1);
   }

   private void LoadVolume()
   {
      
   }
}
