using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyMeat : MonoBehaviour
{

    public Text meatOrderText;
    public GameObject deliverShop;

    //increases the meatorder
    public void increase()
    {
        Debug.Log(GameManager.Instance.tempOrderMeat);
        if (GameManager.Instance.tempFeedGrain > 0 && GameManager.Instance.tempMoney > 0)
        {
            GameManager.Instance.tempFeedGrain--;
            GameManager.Instance.tempMoney--;
            GameManager.Instance.tempOrderMeat++;
            meatOrderText.text = GameManager.Instance.tempOrderMeat.ToString();
        }
    }

    //decreases the meatorder
    public void decrease()
    {
        
        if (GameManager.Instance.tempOrderMeat > 0)
        {
            GameManager.Instance.tempFeedGrain++;
            GameManager.Instance.tempMoney++;
            GameManager.Instance.tempOrderMeat--;
            meatOrderText.text = GameManager.Instance.tempOrderMeat.ToString();
        }
    }

    //buy the meatorder
    public void buy()
    {
        GameManager.Instance.orderedMeat += GameManager.Instance.tempOrderMeat;
        GameManager.Instance.FeedGrain = GameManager.Instance.tempFeedGrain;
        GameManager.Instance.Money = GameManager.Instance.tempMoney;
        GameManager.Instance.tempOrderMeat = 0;
        meatOrderText.text = GameManager.Instance.tempOrderMeat.ToString();
    }

    //closes the shop
    public void closeShop()
    {
        deliverShop.SetActive(false);

    }

    //closes the personalist
    public void closePersonaList()
    {
        deliverShop.SetActive(false);
        foreach (GameObject g in GameManager.Instance.personaObjects)
        {

            g.transform.parent = null;
        }
    }

}
