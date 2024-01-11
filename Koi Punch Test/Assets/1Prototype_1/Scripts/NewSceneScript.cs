using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewSceneScript : BreakWhenHit
{
    [SerializeField] private string _newSceneName;
    [SerializeField] private GameObject _fadeScreenObj;
    private FadeScreen _fadeScreen;

    private void Start()
    {
        _fadeScreenObj = GameObject.FindGameObjectWithTag("FadeScreen");
        _fadeScreen = _fadeScreenObj.GetComponent<FadeScreen>();
    }
    public void OnMouseDown()
    {
        HittingSign();
        
        StartCoroutine(GoToSceneRoutine());
    }

    IEnumerator GoToSceneRoutine()
    {
        _fadeScreen.FadeOut();
        yield return new WaitForSeconds(_fadeScreen.fadeDuration);
        
        SceneManager.LoadScene(_newSceneName);
    }
}
