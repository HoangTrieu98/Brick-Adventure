using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingPanelAnimation : MonoBehaviour
{

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void ActivePanel()
    {
        animator.SetTrigger("OpenPanel");
    }

    public void DeactivePanel()
    {
        animator.SetTrigger("ClosePanel");
    }


}
