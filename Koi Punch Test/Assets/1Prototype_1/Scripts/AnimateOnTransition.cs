using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateOnTransition : MonoBehaviour
{
    public Animator animator;

    private void Start()
    {
        EventManager.ExplodeEvent += ExplodeTransition;
    }
    private void ExplodeTransition()
    {
        animator.Play("Exit");
        Destroy(gameObject,0.6f);
    }
    
    private void OnDisable()
    {
        EventManager.ExplodeEvent -= ExplodeTransition;
    }
    
    
}