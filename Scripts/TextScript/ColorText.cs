using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorText : MonoBehaviour
{

    public Text colorText;
    // 0 = money, 1 = grain, 2 = feedgrain, 3 = meat
    public int Resource;
    public int ResourceType;

    //changes color of the text if there isn't enough resources
    void Update()
    {
        checkResource();
        if (Resource < int.Parse(colorText.text))
        {
            colorText.color = Color.red;
        }
        else
        {
            colorText.color = Color.black;
        }
    }

    // check resources
    public void checkResource()
    {
        if (ResourceType == 0)
        {
            Resource = GameManager.Instance.tempMoney;
        }
        else if (ResourceType == 1)
        {
            Resource = GameManager.Instance.tempGrain;
        }
        else if (ResourceType == 2)
        {
            Resource = GameManager.Instance.tempFeedGrain;
        }
        else if (ResourceType == 3)
        {
            Resource = GameManager.Instance.tempMeat;
        }
    }
}
