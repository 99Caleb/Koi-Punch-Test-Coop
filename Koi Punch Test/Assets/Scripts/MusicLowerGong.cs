using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicLowerGong : MonoBehaviour
{
    public void OnMouseDown()
    {
        PlayerPrefs.SetInt("MusicVolume", PlayerPrefs.GetInt("MuiscVolume") - 1);
        //Play Gong noise at new volume
    }
}
