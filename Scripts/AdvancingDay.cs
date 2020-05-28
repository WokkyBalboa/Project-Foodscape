using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdvancingDay : MonoBehaviour
{

    public Health environmentHealth;
    public Health happinessHealth;
    public GameObject truck;
    public Text day;

    //shows all the actions which goes with a day advance
    //plants grow
    //days increases
    //environment improves
    public void load()
    {
   
        GameManager.Instance.PlantGrow++;
        GameManager.Instance.DayShow++;
        deliveryShop();
        reloadDay();
        mealPlan();
        dayName();
        environmentHealth.IncreaseHealth(1);

    }

    //the delivery shop only shows up every sunday
    public void deliveryShop()
    {
        if (GameManager.Instance.Day == 5)
        {
            truck.SetActive(true);
            environmentHealth.DecreaseHealth(10);
            meatEnvironment();
            GameManager.Instance.Meat += 
                GameManager.Instance.orderedMeat;
            GameManager.Instance.orderedMeat = 0;
        }
        else
        {
            truck.SetActive(false);
        }
    }

    //meat orders lowers environment health
    public void meatEnvironment()
    {
        if (GameManager.Instance.orderedMeat != 0)
        {
            environmentHealth.DecreaseHealth(
                GameManager.Instance.orderedMeat * 2);
        }
    }

    //resets the week when sunday passes
    public void reloadDay()
    {
        if(GameManager.Instance.Day == 6){
            GameManager.Instance.Day = 0;
        }
        else
        {
            GameManager.Instance.Day++;
        }
    }

    //health increases/decreases depending on various variables
    public void mealPlan()
    {
        if (GameManager.Instance.MealPlan == 0)
        {
            happinessHealth.DecreaseHealth(15);
        }

        else if (GameManager.Instance.MealPlan == 1 && GameManager.Instance.Grain >= (GameManager.Instance.population * 2))
        {
            GameManager.Instance.Grain -= (GameManager.Instance.population * 2);
            foreach(List<string> k in GameManager.Instance.personas)
            {
                foreach(string l in k)
                {
                    if(l == "Vegetarian" || l == "SustainableEater")
                    {
                        happinessHealth.IncreaseHealth(5);
                    }
                }
            }
        }
        else if (GameManager.Instance.MealPlan == 2 && GameManager.Instance.Grain >= GameManager.Instance.population && GameManager.Instance.Meat >= GameManager.Instance.population + GameManager.Instance.MeatModifier)
        {
            GameManager.Instance.Grain -= GameManager.Instance.population;
            GameManager.Instance.Meat -= GameManager.Instance.population + GameManager.Instance.MeatModifier;
            happinessHealth.IncreaseHealth(5 * GameManager.Instance.population);
        }
        else
        {
            happinessHealth.DecreaseHealth(15);
        }
    }

    //sets the day name
    public void dayName()
    {
        day.text = "Day: " + GameManager.Instance.DayShow + " " + GameManager.Instance.DayName[GameManager.Instance.Day];
    }
}
