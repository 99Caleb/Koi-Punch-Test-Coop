using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuChanger : MonoBehaviour
{
    public GameObject currentGate;
    public GameObject newGate;
    public GameObject destroyedVersion;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered");
        GetDestroyed();
    }

    public void GetDestroyed()
    {
        Instantiate(destroyedVersion, transform.position, transform.rotation);
        Instantiate(newGate);
        currentGate.GetComponent<MenuGatesScript>().FallOver();
        Destroy(gameObject);
    }
    

}
