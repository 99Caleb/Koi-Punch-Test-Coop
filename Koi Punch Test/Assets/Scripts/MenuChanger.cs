using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuChanger : MonoBehaviour
{
    public GameObject toriiGate;
    public GameObject tiltBox;
    public GameObject newMenuGate;
    public GameObject destroyedVersion;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered");
        GetDestroyed();
    }

    public void GetDestroyed()
    {
        Instantiate(destroyedVersion, transform.position, transform.rotation);
        Instantiate(newMenuGate);
        Destroy(gameObject);
        Rigidbody toriiGateRigidbody = toriiGate.GetComponent<Rigidbody>();
        toriiGateRigidbody.isKinematic = false;
        Vector3 direction = new Vector3(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, -30);
        Quaternion targetRotation = Quaternion.Euler(direction);
        tiltBox.transform.rotation = Quaternion.Lerp(this.transform.rotation, targetRotation, Time.deltaTime * 1);
        Invoke("FallOver", 5f);
        /*Debug.Log("Yield returned");
        Vector3 backdirection = new Vector3(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 30);
        Quaternion targetRotation = Quaternion.Euler(backdirection);
        tiltBox.transform.rotation = Quaternion.Lerp(this.transform.rotation, targetRotation, Time.deltaTime * 1);
        Destroy(toriiGate);*/
    }

    public void FallOver()
    {
        Debug.Log("Yield returned");
        Vector3 backDirection = new Vector3(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 30);
        Quaternion targetRotation = Quaternion.Euler(backDirection);
        tiltBox.transform.rotation = Quaternion.Lerp(this.transform.rotation, targetRotation, Time.deltaTime * 1);
        //tiltBox.transform.rotation = Quaternion.RotateTowards(this.transform.rotation, Quaternion.Euler(0.0f, 0.0f, 50), 100 * Time.deltaTime);
        Destroy(toriiGate);
    }
}
