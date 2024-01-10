using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTransition : MonoBehaviour
{
    public Animator animator;
    [SerializeField] private int hello;
    

    private void Start()
    {
        EventManager.ExplodeEvent += ExplodeTransition;
    }
    private void ExplodeTransition()
    {
        animator.Play("Explode");
        Destroy(gameObject,0.6f);
    }
    
    private void OnDisable()
    {
        EventManager.ExplodeEvent -= ExplodeTransition;
    }
    
    
}
