using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Android.Gradle.Manifest;
using UnityEngine;

public class DestroyPrefabAfterTime : MonoBehaviour
{
    private MeshRenderer _meshRenderer;
    private Color spriteColor;
    private void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        Color spriteColor = _meshRenderer.materials[0].color;
        Invoke("FadeOutAndDestroy",4);
    }

    
    
    private void FadeOutAndDestroy()
    {
        while (spriteColor.a > 0)
        {
            spriteColor.a -= .1f;
        }
        Destroy(gameObject);
    }
}
