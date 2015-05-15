using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class OnCollisionPickUp : MonoBehaviour
{

    PlayerInventory inventory;

    void Awake()
    {
        inventory = gameObject.GetComponentInChildren<PlayerInventory>();
        DontDestroyOnLoad(gameObject);
    }

    
    //void onTriggerEnter(Collider other)
    void OnControllerColliderHit(ControllerColliderHit other)
    {
        switch (other.gameObject.tag)
        {
            case "Resource":
                int scrapValue = other.gameObject.GetComponent<Resource>().value;
                //pickable objects have different values
                if (scrapValue >= 5)
                    inventory.scraps_special += scrapValue;
                else if (scrapValue < 5)
                    inventory.scraps += scrapValue;
                    
                Object.Destroy(other.gameObject);
                break;
            case "Item":
                //items will always have a playerinventory script attached to them
                //gameObject.GetComponentInChildren<PlayerInventory>().items.Add(gameObject);
                other.gameObject.GetComponent<IPickup>().PickUp();
                break;
            default: break;
        }

        //Object.Destroy(other.gameObject);
        //check other object's tags to determine what to do
        //if (other.gameObject.tag == "Pickable")
        //{
            
            // mTags = other.gameObject.GetComponent<MiscTags>();

        //}




        /*
        switch(mTags.mTag01)
        {
            case "Item":
                {
                    //gameObject.GetComponentInChildren<PlayerInventory>().items.Add(gameObject);
                    //other.gameObject.transform.parent = gameObject.transform;
                    //other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                    //other.gameObject.transform.localPosition = new Vector3(0, 1, 2);
                }
                break;
            case "Resource":
                {

                       
                    /*
                    if (mTags.mTag02 == "Scrap")
                    {
                        Object.Destroy(other.gameObject);
                        inventory.scraps++;
                           
                    }
                        
                    else
                    {
                        Object.Destroy(other.gameObject); 
                        inventory.scraps_special++;
               
                }
                break;
        }*/

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

