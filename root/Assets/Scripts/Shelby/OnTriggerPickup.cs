using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class OnTriggerPickUp : MonoBehaviour
{

    Database items;

    void Awake()
    {
        items = gameObject.GetComponentInChildren<Database>();
        DontDestroyOnLoad(gameObject);
    }


    //void onTriggerEnter(Collider other)
    void OnControllerColliderHit(ControllerColliderHit other)
    {
        switch (other.gameObject.tag)
        {
            case "Resource":
                int scrapValue = other.gameObject.GetComponent<Resource>().value;
                // resource objects have different values
                if (scrapValue >= 5)
                    items.scraps_special += scrapValue;
                else if (scrapValue < 5)
                    items.scraps += scrapValue;

                Object.Destroy(other.gameObject);
                break;
            case "Item":
                //items will always have a playeritems script attached to them
                //gameObject.GetComponentInChildren<items>().items.Add(gameObject);
                other.gameObject.GetComponent<IPickup>().PickUp();
                break;
            default: break;
        }

    }
}

