using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakWhenHit : AnimateOnTransition
{
    [SerializeField] private GameObject breakPrefab;
    
    protected void HittingSign()
    {
        Instantiate(breakPrefab,gameObject.transform.position,Quaternion.identity);
        EventManager.ExplodeTransition();
        if (gameObject.CompareTag("SceneChanger"))
        {
            gameObject.transform.localScale = new Vector3(0, 0, 0);
        }
        else
        {
            Destroy(gameObject);
        }
    }

}