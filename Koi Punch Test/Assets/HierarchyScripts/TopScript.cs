using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopScript : MonoBehaviour
{
    private Animator _anim;
    public AnimationClip explodeAnim;

    private void Start()
    {
        _anim = GetComponent<Animator>();
    }


    protected void Explode()
    {
        _anim.Play(explodeAnim.ToString());
    }
}
