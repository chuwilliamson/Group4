using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class OnCollisionPickUp : MonoBehaviour
{

    Inventory inventory;

    void Awake()
    {
        inventory = gameObject.GetComponentInChildren<Inventory>();
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
                    inventory.scraps_special += scrapValue;
                else if (scrapValue < 5)
                    inventory.scraps += scrapValue;
                    
                Object.Destroy(other.gameObject);
                break;
            case "Item":
                //items will always have a playerinventory script attached to them
                //gameObject.GetComponentInChildren<Inventory>().items.Add(gameObject);
                other.gameObject.GetComponent<IPickup>().PickUp();
                break;
            default: break;
        }

        //print(gameObject.name);
        //if (other.gameObject.tag == "Item")
        //{
        //    gameObject.GetComponentInChildren<PlayerInventory>().items.Add(gameObject);
        //    other.gameObject.transform.parent = gameObject.transform;
        //    other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
        //    other.gameObject.transform.localPosition = new Vector3(0, 1, 2);

        //    print("Picked up " + other.gameObject.name);
        //}

        //if (other.gameObject.GetComponent<MiscTags>().mTag01 == "Resource")
        //{
        //    print("Resource");
        //    if (other.gameObject.GetComponent<MiscTags>().mTag02 == "Scrap")
        //    {
        //        print("Scrap");
        //        //Object.Destroy(other.gameObject);
        //        //gameObject.GetComponent<PlayerInventory>().scraps++;
        //    }
        //    else
        //    {
        //        print("Special Scrap");
        //        //Object.Destroy(other.gameObject);
        //        //gameObject.GetComponent<PlayerInventory>().scraps_special++;
        //    }
        //}
    }
}

