using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventManager : MonoBehaviour
{
    public static event Action ExplodeEvent;

    public static void SceneTransition()
    {
        if (ExplodeEvent != null)
        {
            ExplodeEvent();
        }
    }
}
