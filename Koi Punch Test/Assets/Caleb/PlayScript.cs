using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayScript : SceneTransition
{
    [SerializeField] private GameObject breakPrefab;
    
    private void OnMouseDown()
    {
        var position = transform.position;
        Instantiate(breakPrefab,new Vector3(position.x,position.y + 1, position.z),Quaternion.Euler(new Vector3(0,0,0)));
        Destroy(gameObject);
        EventManager.ExplodeTransition();
        
        //Coding coding coding coding coding coding coding coding coding coding coding coding coding fancy coding coding coding coding coding coding coding coding coding coding coding coding coding coding coding coding coding coding
        //coding coding coding coding coding coding coding coding coding coding coding coding coding
    }

}
