using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuChanger : MonoBehaviour
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
        GateFall();
    }

    private void GateFall()
    {
        
    }
}
