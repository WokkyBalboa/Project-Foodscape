using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuySell : MonoBehaviour
{
    public Text OrderText;
    public int resource;

    //increase the buy/sell amount
    public void increase()
    {
        GameManager.Instance.resourceAmount++;
            OrderText.text = GameManager.Instance.resourceAmount.ToString();
    }

    //decrease the buy/sell amount
    public void decrease()
    {
        if (GameManager.Instance.resourceAmount != 0)
        {
            GameManager.Instance.resourceAmount--;
            OrderText.text = GameManager.Instance.resourceAmount.ToString();
        }
    }

    //buy the resource
    public void buy()
    {
        switch (resource)
        {
            case 1:
                if (!(GameManager.Instance.Money - GameManager.Instance.resourceAmount < 0))
                {
                    GameManager.Instance.Grain += GameManager.Instance.resourceAmount;
                    GameManager.Instance.Money -= GameManager.Instance.resourceAmount;
                    GameManager.Instance.resourceAmount = 0;
                    OrderText.text = GameManager.Instance.resourceAmount.ToString();
                }
                break;
            case 2:
                if (!(GameManager.Instance.Money - GameManager.Instance.resourceAmount < 0))
                {
                    GameManager.Instance.FeedGrain += GameManager.Instance.resourceAmount;
                    GameManager.Instance.Money -= GameManager.Instance.resourceAmount;
                    GameManager.Instance.resourceAmount = 0;
                    OrderText.text = GameManager.Instance.resourceAmount.ToString();
                }
                break;
        }
                
    }

    //sell the resource
    public void sell()
    {
        switch (resource)
        {
            case 1:
                if (!(GameManager.Instance.Grain - GameManager.Instance.resourceAmount < 0))
                {
                    GameManager.Instance.Grain -= GameManager.Instance.resourceAmount;
                    GameManager.Instance.Money += GameManager.Instance.resourceAmount;
                    GameManager.Instance.resourceAmount = 0;
                    OrderText.text = GameManager.Instance.resourceAmount.ToString();
                }
                break;
            case 2:
                if (!(GameManager.Instance.FeedGrain - GameManager.Instance.resourceAmount < 0))
                {
                    GameManager.Instance.FeedGrain -= GameManager.Instance.resourceAmount;
                    GameManager.Instance.Money += GameManager.Instance.resourceAmount;
                    GameManager.Instance.resourceAmount = 0;
                    OrderText.text = GameManager.Instance.resourceAmount.ToString();
                }
                break;
            case 3:
                if (!(GameManager.Instance.Meat - GameManager.Instance.resourceAmount < 0))
                {
                    GameManager.Instance.Meat -= GameManager.Instance.resourceAmount;
                    GameManager.Instance.Money += (GameManager.Instance.resourceAmount * 5);
                    GameManager.Instance.resourceAmount = 0;
                    OrderText.text = GameManager.Instance.resourceAmount.ToString();
                }
                break;
        }
    }


}
