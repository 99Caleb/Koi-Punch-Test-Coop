using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChanger : MonoBehaviour
{
    public string newScene;
    
    private void OnTriggerEnter(Collider other)
    {
        //make the sign explode from previous script & all other signs explode
        Debug.Log("Hit");
    }
    

}
