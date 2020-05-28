using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ImageActivator : MonoBehaviour
{
    public GameObject show1;
        public GameObject show2;

    //shows or closes an gameobject
    void OnMouseUp()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            if (show1.activeSelf == true)
            {
                if (show1 != null)
                {
                    show1.SetActive(false);
                }
                if (show2 != null)
                {
                    show2.SetActive(false);
                }
            }
            else
            {
                if (show1 != null)
                {
                    show1.SetActive(true);
                }
                if (show2 != null)
                {
                    show2.SetActive(true);
                }
            }
        }
    }
}
