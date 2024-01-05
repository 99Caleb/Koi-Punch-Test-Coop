using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuChanger : MonoBehaviour
{
    public GameObject toriiGate;
    public GameObject tiltBox;
    
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
        Rigidbody toriiGateRigidbody = toriiGate.GetComponent<Rigidbody> ();
        toriiGateRigidbody.isKinematic = false;
        //tiltBox.gameObject.transform.rotation = Quaternion.Euler(new Vector3(60, 0, 0));
        tiltBox.transform.rotation = Quaternion.RotateTowards(this.transform.rotation, Quaternion.Euler(0.0f, 0.0f, -50), 100 * Time.deltaTime);
    }
}
