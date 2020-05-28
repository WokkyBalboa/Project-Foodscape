using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrainText : MonoBehaviour
{

    public Text grainText;
    //set the text to this GameObject
    void Start()
    {
        grainText = this.gameObject.GetComponent<Text>();
    }

    //displays the grain amount
    void Update()
    {
        grainText.text = GameManager.Instance.Grain.ToString();
    }
}
