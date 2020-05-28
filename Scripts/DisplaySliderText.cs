using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplaySliderText : MonoBehaviour
{

    public Health displayHealth;
    public Text displayText;

    private void Start()
    {
        displayText = this.GetComponent<Text>();
    }

    void Update()
    {
        displayText.text = displayHealth.getHealth().ToString();
    }
}
