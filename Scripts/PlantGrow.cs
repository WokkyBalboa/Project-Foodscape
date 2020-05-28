using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlantGrow : MonoBehaviour
{
    public GameObject Seed;
    public GameObject Plant;
    public int growDays;
    public int growingDays;

    private void Start()
    {
        Seed = this.gameObject;
        growDays = 0;
        growingDays = GameManager.Instance.PlantGrow;
    }

    //if the int of growdays is not the same anymore as growingdays it'll increase it values
    private void Update()
    {
        if (growingDays != GameManager.Instance.PlantGrow)
        {
            growDays++;
            growingDays = GameManager.Instance.PlantGrow;
            if(growDays == GameManager.Instance.PlantGrowDays)
            {
                Grow();
            }
        }
    }

    //replaces the current GameObject with an similar Gameobject which can be harvested.
    void Grow()
    {
        instantiate();
        destroy();
    }

    void instantiate()
    {
        Instantiate(Plant, Seed.transform.position, Quaternion.identity);
    }


    void destroy()
    {
        Destroy(Seed);
    }

}
