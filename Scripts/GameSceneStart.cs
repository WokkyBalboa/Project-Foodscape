using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSceneStart : MonoBehaviour
{
    //Health
    public Slider EnvironmentSlider;
    public Slider HappinessSlider;

    public GameObject persona;
    public GameObject canvas;
    public GameObject personaList;
    public GameObject gameOver;

    public int score;

    public Text scoreText;
    

    void Start()
    {
        score = 0;
        for (int i = 0; i != GameManager.Instance.population; i++)
        {
            GameObject person = Instantiate(persona);
        }

    }

    private void Update()
    {
        GameOver();
    }

    public void GameOver()
    {
        
        if (EnvironmentSlider.value == 0)
        {
           calculateScore();
           gameOver.SetActive(true);
            EnvironmentSlider.value = 100;
        }
        else if (HappinessSlider.value == 0)
        {
            calculateScore();
            gameOver.SetActive(true);
            HappinessSlider.value = 100;
        }
        else if (GameManager.Instance.DayShow == 30)
        {
            calculateScore();
            gameOver.SetActive(true);
            GameManager.Instance.DayShow = 31;
        }
    }

    public void calculateScore()
    {
        score += GameManager.Instance.DayShow * 1000;
        score += (int)EnvironmentSlider.value * 1000;
        score += (int)HappinessSlider.value * 1000;
        score += GameManager.Instance.Money * 1000;
        scoreText.text = "Days Survived:    " + GameManager.Instance.DayShow * 1000 + "\nEnvironmental Score:  " 
            + (int)EnvironmentSlider.value * 1000 + "\nHappiness Score:    " + (int)HappinessSlider.value * 1000 
            +  "\nMoney Score:    " + GameManager.Instance.Money * 1000 + "\n\nTotal Score:  " +score.ToString();
    }
}
