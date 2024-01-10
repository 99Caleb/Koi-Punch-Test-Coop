using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewSceneScript : MonoBehaviour
{
    [SerializeField] private string _newSceneName;
    [SerializeField] private FadeScreen _fadeScreen;
    
    public void OnMouseDown()
    {
        // break sign
        // make all other signs break
        
        // fade to white
        // go to new scene
        StartCoroutine(GoToSceneRoutine());
    }

    IEnumerator GoToSceneRoutine()
    {
        _fadeScreen.FadeOut();
        yield return new WaitForSeconds(_fadeScreen.fadeDuration);
        
        //launch new scene
        SceneManager.LoadScene(_newSceneName);
    }
}
