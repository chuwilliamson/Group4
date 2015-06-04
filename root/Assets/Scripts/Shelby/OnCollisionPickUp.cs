using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class OnCollisionPickUp : MonoBehaviour
{
    public ItemDatabase pInventory;

    //Database inventory;

    void Awake()
    {
        //pInventory = gameObject.GetComponentInChildren<ItemDatabase>();
        DontDestroyOnLoad(gameObject);
    }

    
    //void onTriggerEnter(Collider other)
    void OnControllerColliderHit(ControllerColliderHit other)
    {
        switch (other.gameObject.tag)
        {
            case "Resource":
                int n_scraps = other.gameObject.GetComponent<Resource>().value;
                //int n_specialScraps = 
                // resource objects have different values
                if (n_scraps >= 11)
                    pInventory.scraps_special += 1;
                else
                    pInventory.scraps += n_scraps;
                other.gameObject.GetComponent<IPickup>().PickUp();
                
                break;
            case "Item":
                //items will always have a playerinventory script attached to them
                //gameObject.GetComponentInChildren<Inventory>().items.Add(gameObject);
                ShelbyDatabase.instance.AddSingleItem(other.gameObject, pInventory);
                
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

