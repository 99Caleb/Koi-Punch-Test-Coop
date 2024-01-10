using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{
    public GameObject destroyedVersion;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered");
        GetDestroyed();
    }

    public void GetDestroyed()
    {
        Instantiate(destroyedVersion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
