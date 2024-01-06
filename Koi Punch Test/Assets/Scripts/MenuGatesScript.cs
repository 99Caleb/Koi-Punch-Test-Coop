using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuGatesScript : MonoBehaviour
{
    private Animator _anim;

    private void Awake()
    {
        _anim = gameObject.GetComponent<Animator>();
    }

    void Start()
    {
        _anim.Play("GongGateLanding");
    }

}
