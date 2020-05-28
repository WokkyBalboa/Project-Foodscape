using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    public Slider slider;

    //sets the slider to the GameObject this script is attached to
    public void Start()
    {
        slider = this.gameObject.GetComponent<Slider>();
    }

    //function to set the max health
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;

    }

    //function to set the current health
   public void SetHealth(int health)
    {
        slider.value = health;
    }

    //function to decrease health
    public void DecreaseHealth(int health)
    {
        slider.value -= health;
    }

    //function to increase health
    public void IncreaseHealth(int health)
    {
        slider.value += health;
    }

    public float getHealth()
    {
        return slider.value;
    }
}
