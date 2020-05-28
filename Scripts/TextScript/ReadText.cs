using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadText : MonoBehaviour
{
    public Text text;
    public TextAsset textFile;
    public GameObject deactivate;
    public GameObject activated;
    public int i;
    public bool check = true;
    public bool setactive;
    public bool setdeactive;
    private bool touch = false;
    string[] TextLine;

    //Start reading the textfile and skips at every \n
    void Start()
    {
        if (textFile != null)
        {
            TextLine = (textFile.text.Split('\n'));
        }
    }

    //Start at the beginning of the text
    private void OnEnable()
    {
        i = 0;
    }

    //checks if the textfile is empty otherwise go to next line
    void LateUpdate()
    {
        deact();
        text.text = TextLine[i];
        load();
    }

    //checks if there is an input
    bool checkInputTouch()
    {
        return (Input.touchCount > 1);
    }

    //deactivates when the textfile has reached it end
    public void deact()
    {
        if (i == TextLine.Length)
        {
            i = 0;
            if (setdeactive)
            {
                deactivate.SetActive(false);
            }
            if (setactive)
            {
                activated.SetActive(true);
            }
            
        }
    }

    public void touchCheck()
    {
        if (checkInputTouch() == false)
        {
            touch = false;
        }
    }

    //go to next line in the textfile
    public void load()
    {
        if (touch = false && checkInputTouch() == true || Input.GetMouseButtonDown(0))
        {
            i++;
            touch = true;
        }
    }
}
