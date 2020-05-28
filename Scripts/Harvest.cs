using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Harvest : MonoBehaviour
{
    public GameObject harvest;
    public GameObject feedGrain;
    public GameObject grain;
    public GameObject ground;

    //sets the harvest GameObject to this GameObject
    public void Start()
    {
        harvest = this.gameObject;
    }

    //"harvests" the crop increase yield based on modifier
    private void OnMouseDown()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            if (harvest == feedGrain)
            {
                GameManager.Instance.FeedGrain += GameManager.Instance.HarvestModifier;
            }
            if (harvest == grain)
            {
                GameManager.Instance.Grain += GameManager.Instance.HarvestModifier;
            }

            takeHarvest();
        }
    }

    //destroy the gameobject and create a new "workable ground" 
    private void takeHarvest()
    {
        instantiate();
        destroy();
    }

    void instantiate()
    {
        Instantiate(ground, harvest.transform.position, Quaternion.identity);
    }


    void destroy()
    {
        Destroy(harvest);
    }

}
