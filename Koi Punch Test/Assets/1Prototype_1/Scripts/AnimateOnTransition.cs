using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateOnTransition : MonoBehaviour
{
     private Animator _animator;
    //[SerializeField] private string _explodingAnimClip;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        EventManager.ExplodeEvent += ExplodeTransition;
    }
    private void ExplodeTransition()
    {
        _animator.SetTrigger("TransitionAnimation");
        //_animator.Play(_explodingAnimClip);
        Destroy(gameObject,5f);
    }
    
    private void OnDisable()
    {
        EventManager.ExplodeEvent -= ExplodeTransition;
    }
    
    
}