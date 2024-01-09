using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTransition : MonoBehaviour
{
    public Animator animator;
    public bool isParentScript;

    private void Start()
    {
        EventManager.ExplodeEvent += OnTransition;
    }

    public void OnTransition()
    {
        animator.Play("Explode");
        Invoke("DestroyThisObject",.6f);
    }

    public void DestroyThisObject()
    {
        Destroy(gameObject);
    }

    public void OnDisable()
    {
        EventManager.ExplodeEvent -= OnTransition;
    }
}
