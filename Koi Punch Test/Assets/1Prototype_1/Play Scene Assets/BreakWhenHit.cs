using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakWhenHit : AnimateOnTransition
{
    [SerializeField] private GameObject breakPrefab;
    
    private void OnMouseDown()
    {
        Instantiate(breakPrefab,gameObject.transform.position,Quaternion.identity);
        EventManager.ExplodeTransition();
        Destroy(gameObject);
    }

}