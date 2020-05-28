using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MealTextColor : MonoBehaviour
{

    public Text colorText;
    public int mealPlan;

    void Update()
    {
        checkMealPlan();
    }

    //checks if there is enough resources for the meal plan
    public void checkMealPlan()
    {
        if (mealPlan == GameManager.Instance.MealPlan)
        {
            colorText.color = Color.blue;
        }
        else
        {
            colorText.color = Color.black;
        }
    }
}
