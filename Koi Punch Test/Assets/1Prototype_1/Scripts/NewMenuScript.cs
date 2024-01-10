using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewMenuScript : MonoBehaviour
{
    [SerializeField] private GameObject newMenuParent;
    
    public void OnMouseDown()
    {
        // break sign
        // make all other signs break
        
        // make new signs appear, instantiate
        Instantiate(newMenuParent);
    }
}
