using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateOnTransition : MonoBehaviour
{
    private Animator _animator;
    [SerializeField] private string _explodingAnimClip;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        EventManager.ExplodeEvent += ExplodeTransition;
    }
    private void ExplodeTransition()
    {
        if(_explodingAnimClip == null)
        {
            Debug.Log("audio clip not found");
            return;
        }
        _animator.Play(_explodingAnimClip);
        Destroy(gameObject,1f);
    }
    
    private void OnDisable()
    {
        EventManager.ExplodeEvent -= ExplodeTransition;
    }
    
    
}