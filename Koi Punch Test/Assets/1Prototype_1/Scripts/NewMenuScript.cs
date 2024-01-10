using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewMenuScript : BreakWhenHit
{
    [SerializeField] private GameObject newMenuParent;
    
    public void OnMouseDown()
    {
        HittingSign();
        // make all other signs break
        
        // make new signs appear, instantiate
        Instantiate(newMenuParent);
    }
}
