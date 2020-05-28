using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OpenShop : MonoBehaviour
{

    public GameObject shop;

    //Opens the shop with new temporary resources
    private void OnMouseDown()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            shop.SetActive(true);
            GameManager.Instance.tempFeedGrain = GameManager.Instance.FeedGrain;
            GameManager.Instance.tempGrain = GameManager.Instance.Grain;
            GameManager.Instance.tempMeat = GameManager.Instance.Meat;
            GameManager.Instance.tempMoney = GameManager.Instance.Money;

            Debug.Log(GameManager.Instance.tempMoney + " " + GameManager.Instance.tempFeedGrain);
        }
    }
}
