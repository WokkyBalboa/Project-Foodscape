using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeedGrainText : MonoBehaviour
{
    public Text feedGrainText;
    //set the text to this GameObject
    void Start()
    {
        feedGrainText = this.gameObject.GetComponent<Text>();
    }

    //displays the feed grain amount
    void Update()
    {
        feedGrainText.text = GameManager.Instance.FeedGrain.ToString();
    }
}
