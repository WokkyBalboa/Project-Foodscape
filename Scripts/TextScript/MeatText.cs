using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeatText : MonoBehaviour
{
    public Text meatText;
    //set the text to this GameObject
    void Start()
    {
       meatText = this.gameObject.GetComponent<Text>();
    }

    // display your current meat
    void Update()
    {
        meatText.text = GameManager.Instance.Meat.ToString();
    }
}
