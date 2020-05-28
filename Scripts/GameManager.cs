using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    //Orders
    public int orderedMeat = 0;

    //Persona
    public List<List<string>> personas = new List<List<string>>();
    public List<GameObject> personaObjects = new List<GameObject>();
    public List<string> namesFirst = new List<string>{"Tom", "Dirk", "Jos", "Alex" };
    public List<string> namesLast = new List<string> { "Hamerlaar", "Spijkerder", "Tollaar", "Vergiet" };
    public List<string> traitsPositive = new List<string> { "NothingP","Hardworker", "Haggler", "Vegetarian" };
    public List<string> traitsNegative = new List<string> { "NothingN","Lazy", "HeadStrong", "Meatlover" };

    //Resources
    public int FeedGrain = 30;
    public int Grain = 30;
    public int Money = 30;
    public int Meat = 5;
    public int population = 3;

    //Shop temp numbers
    public int tempOrderMeat;

    //Temp resources
    public int tempGrain = 0;
    public int tempFeedGrain = 0;
    public int tempMoney = 0;
    public int tempMeat = 0;
    public int resourceAmount = 0;

    //Other    
    public int PlantGrow = 0;
    public int PlantGrowDays = 3;
    public int Day = 0;
    public int DayShow = 0;
    public List<string> DayName = new List<string> {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
    public int MealPlan = 1;

    //Modifiers
    public int HarvestModifier = 2;
    public int MeatModifier = 0;
    public int FoodModifier = 0;

    public static GameManager Instance;

    // Create an Instance of the GameManager when the Game is opened
    private void Awake()
    {
        Instance = this;
    }



}
