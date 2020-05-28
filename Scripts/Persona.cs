using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Persona : MonoBehaviour
{
    public List<string> persona;
    public string nameFirst;
    public string nameLast;
    public string trait1;
    public string trait2;
    public int sustainableDays;
    public int sustainable;
    public GameObject gameobject;
    public Text text;
    public bool sustainbleEating;

    // instantiate an persona object with randomized names and traits
    void Start()
    {
        gameobject = this.gameObject;
        text = this.gameObject.GetComponent<Text>();
        sustainbleEating = false;
        sustainableDays = GameManager.Instance.Day;
        sustainable = 0;

        persona = new List<string>();
        nameFirst = GameManager.Instance.namesFirst[Random.Range
            (0, GameManager.Instance.namesFirst.Count)];
        nameLast = GameManager.Instance.namesLast[Random.Range
            (0, GameManager.Instance.namesLast.Count)];

        int i = Random.Range(0, 
            GameManager.Instance.traitsPositive.Count);
        int j = Random.Range(0, 
            GameManager.Instance.traitsNegative.Count);
        while (i == j){ 
            i = Random.Range(0, 
                GameManager.Instance.traitsPositive.Count);
            j = Random.Range(0, 
                GameManager.Instance.traitsNegative.Count);
        }

        trait1 = GameManager.Instance.traitsPositive[i];
        trait2 = GameManager.Instance.traitsNegative[j];
        persona.Add(nameFirst);
        persona.Add(nameLast);
        persona.Add(trait1);
        persona.Add(trait2);

        modifier();
        description();
        checker();

        GameManager.Instance.personas.Add(persona);
        GameManager.Instance.personaObjects.Add(gameObject);

    }

    //checks if an persona becomes a sustainable eater
    private void Update()
    {
        if(sustainbleEating == true)
        {
            if(sustainableDays != GameManager.Instance.Day)
            {
                sustainable++;
                if (sustainable == 14)
                {
                    for (int i = 0; i != persona.Count; i++)
                    {
                        if (persona[i] == "Meatlover")
                        {
                            persona[i] = "SustainableEater";
                            GameManager.Instance.MeatModifier -= 2;
                        }
                        if (persona[i] == "NothingN")
                        {
                            persona[i] = "SustainableEater";
                            GameManager.Instance.MeatModifier -= 1;
                        }
                        description();
                    }
                }
                sustainableDays = GameManager.Instance.Day;

            }
        }
        
    }

    //apply modifiers to the game depending on traits
    public void modifier()
    {
        foreach (string k in persona)
        {
            if (k == "Hardworker")
            {
                GameManager.Instance.HarvestModifier += 1;
            }
            else if (k == "Lazy" && 
                GameManager.Instance.HarvestModifier > 1)
            {
                GameManager.Instance.HarvestModifier -= 1;
            }
            else if (k == "Meatlover")
            {
                GameManager.Instance.MeatModifier += 1;
            }
            else if (k == "Vegetarian")
            {
                GameManager.Instance.MeatModifier -= 1;
            }
        }
    }

    //check if the persona can change to a sustainable eater
    public void checker()
    {
        foreach (string k in persona)
        {
            if(k == "Meatlover"||k == "NothingN")
            {
                sustainbleEating = true;
            }
        }
    }

    //display the names and traits of the persona
    public void description()
    {
        text.text = "Name:" + nameFirst + " Last Name:" + nameLast + "\n"  + "Traits:";
   for (int i = 2; i != persona.Count; i++)
        {
            text.text += " " + persona[i];
        }

    }

}
