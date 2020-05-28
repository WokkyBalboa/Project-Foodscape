using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIText : MonoBehaviour
{

    public TextAsset text;
    public GameObject background;
    public Text TextBox;

    private void Start()
    {
        background.SetActive(false);
    }

    //Activates the GameObject if you hover over it
    public void load()
    {
        TextBox.text = text.text;
        background.SetActive(true);
    }

    //Deactivates the GameObject if you leave it
    public void exit()
    {
        background.SetActive(false);
    }
}
