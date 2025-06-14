using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingAnimation : MonoBehaviour
{
    private Animator animator;
    public bool isActive = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void ActiveAnimation()
    {
        isActive = true;
        animator.SetTrigger("OpenAnimation");
    }

    public void DeactiveAnimation()
    {
        isActive = false;
        animator.SetTrigger("CloseAnimation");
    }
}
