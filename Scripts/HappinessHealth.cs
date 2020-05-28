using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HapinessHealth : MonoBehaviour
{
    public Slider hapSlider;

    public void SetMaxEnHealth(int hapHealth)
    {
        hapSlider.highValue = hapHealth;
        hapSlider.value = hapHealth;

    }

    public void SetEnHealth(int hapHealth)
    {
        hapSlider.value = hapHealth;
    }
}
