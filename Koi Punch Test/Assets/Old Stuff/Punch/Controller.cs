using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Animator punchAnimator;
    [SerializeField] private bool canPunch = true;
    void Start()
    {
        punchAnimator.Play("Idle");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canPunch)
        {
            canPunch = false;
            punchAnimator.Play("Punch");
            Invoke("EndPunch",.7f);
        }
    }

    private void EndPunch()
    {
        canPunch = true;
    }
}
