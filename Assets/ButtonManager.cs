using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private SettingAnimation settingAnimation;
    [SerializeField] private SettingPanelAnimation settingPanelAnimation;

    public void SettingButton()
    {
        if (!settingAnimation.isActive)
        {
            settingAnimation.ActiveAnimation();
            settingPanelAnimation.ActivePanel();
        }
        else
        {
            settingAnimation.DeactiveAnimation();
            settingPanelAnimation.DeactivePanel();
  
        }
    }

    public void StartButton()
    {
        SceneManager.LoadScene("2.GamePlay");
    }

}
