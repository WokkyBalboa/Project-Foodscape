using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyText : MonoBehaviour
{
    public Text moneyText;
    //set the text to this GameObject
    void Start()
    {
        moneyText = this.gameObject.GetComponent<Text>();
    }

    // display your current money
    void Update()
    {
        moneyText.text = GameManager.Instance.Money.ToString();
    }
}
