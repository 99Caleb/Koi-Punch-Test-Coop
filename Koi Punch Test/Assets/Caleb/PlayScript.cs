using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayScript : SceneTransition
{
    public GameObject parentObject;
    
    public void OnMouseDown()
    {
        Debug.Log("Heyeeyeyeyeyea");
        EventManager.SceneTransition();
    }

}
