using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    public GameObject Ground;
    public GameObject Seed;

    //sets the Ground GameObject to the parent of this GameObject.
    public void Start()
    {
        Ground = transform.parent.gameObject;
    }

    //replaces the current GameObject with an similar GameObject which has an grow timer.
    void OnMouseDown()
    {
        instantiate();
        destroy();
    }

    void instantiate()
    {
        Instantiate(Seed, Ground.transform.position, Quaternion.identity);
    }


    void destroy()
    {
        Destroy(Ground);
    }
        

}
