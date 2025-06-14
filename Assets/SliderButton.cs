using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderButton : MonoBehaviour
{
    [SerializeField] private Slider slider;

    public void SliderClicked()
    {
        if (Mathf.Approximately(slider.value, 1f))
        {
            slider.value = 0f;
        }
        else
        {
            slider.value = 1f;
        }
    }
}
