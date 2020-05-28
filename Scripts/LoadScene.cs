using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{

    public GameObject dontDestroyObject;
    public GameObject dontDestroyObject2;

    void Awake()
    {
      if (dontDestroyObject != null)
        {
            DontDestroyOnLoad(dontDestroyObject);
            if (GameObject.Find(dontDestroyObject.name)
                  && GameObject.Find(dontDestroyObject.name) != this.dontDestroyObject)
        {
            Destroy(GameObject.Find(dontDestroyObject.name));
        }
        }
       if (dontDestroyObject2 != null)
        {
            DontDestroyOnLoad(dontDestroyObject2);
 if (GameObject.Find(dontDestroyObject2.name)
                 && GameObject.Find(dontDestroyObject2.name) != this.dontDestroyObject2)
        {
            Destroy(GameObject.Find(dontDestroyObject2.name));
        }
        }

       

       
    }

    //loads the next scene without destroying a specific GameObject
    public void loadScene(int scene)
    {
        if (dontDestroyObject != null)
        {
            if (!dontDestroyObject.activeSelf)
            {
                dontDestroyObject.SetActive(true);
            }
        }

        SceneManager.LoadScene(scene);
        
    }

}
