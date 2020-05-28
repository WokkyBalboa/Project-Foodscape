using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMeal : MonoBehaviour
{

    public int meal;

    //changes the current meal to the selected meal
   public void load()
    {
        if (GameManager.Instance.tempGrain >= (GameManager.Instance.population * 2))
        {
            GameManager.Instance.MealPlan = meal;
        }
        else if(GameManager.Instance.Grain >= GameManager.Instance.population && GameManager.Instance.Grain >= GameManager.Instance.population)
        {
            GameManager.Instance.MealPlan = meal;
        }
        else
        {
            GameManager.Instance.MealPlan = 0;
        }
    }
}
