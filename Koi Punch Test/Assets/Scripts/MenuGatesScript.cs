using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuGatesScript : MonoBehaviour
{
    private Animator _anim;
    public GameObject tiltBox;
    
    private void Awake()
    {
        _anim = gameObject.GetComponent<Animator>();
    }

    void Start()
    {
        _anim.Play("GongGateLanding");
    }

    public void FallOver()
    {
        StartCoroutine(Falling());
    }
    
    public IEnumerator Falling()
    {
        Debug.Log("Starting Coroutine");
        Rigidbody gateRigidbody = GetComponent<Rigidbody>();
        gateRigidbody.isKinematic = false;
        tiltBox.transform.rotation = Quaternion.Euler(60, 0, 0);
        yield return new WaitForSeconds(2.5f);
        tiltBox.transform.rotation = Quaternion.Euler(0, 0, 0);
        Destroy(gameObject);
    }

}
