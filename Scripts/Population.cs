using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Population : MonoBehaviour
{

    public GameObject gameobject;
    public GameObject canvas;

    //Opens the list of personas
   public void load()
    {
        gameobject.SetActive(true);

        foreach(GameObject g in GameManager.Instance.personaObjects)
        {

            g.transform.SetParent(canvas.transform, false);
        }
    }


}

