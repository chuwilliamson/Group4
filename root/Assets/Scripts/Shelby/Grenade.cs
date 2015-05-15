using UnityEngine;
using System.Collections;

/// <summary>
/// to throw the grenade object we'll need a sphere rigidbody.

// will need to add a force to the grenade object to launch it 
// into the air in the direction the player is facing.

// at start set grenade button to 'G'
// grenade button is set to 'G'
// if 'G' is pressed, spawn a grenade and call AddForce
// if 'G' is not pressed do nothing.
/// <summary>

public class Grenade : MonoBehaviour, IPickup{

    protected Rigidbody rb;
    [SerializeField]
    protected PlayerInventory inventory; //= GameObject.Find("FPSController").GetComponent<PlayerInventory>();

    float timer;
    float impactRadius;
    int damage;

    public void PickUp()
    {
        //print("Picked up a grenade");
        inventory.items.Add(gameObject);
        gameObject.transform.parent = inventory.transform;
        gameObject.GetComponent<Rigidbody>().isKinematic = true;
        //gameObject.SetActive(false);
        inventory.grenades_reg++;
    }


    public void Drop()
    {
        inventory.items.Remove(gameObject);
        inventory.grenades_reg--;

        transform.parent = null;
    }

    public void Drop(bool parent)
    {

        inventory.items.Remove(gameObject);
        inventory.grenades_reg--;

        if(parent)
        {
            transform.parent = GameObject.FindGameObjectWithTag("Player").transform;
        }

    }

    void Throw()
    {
        rb.isKinematic = false;

        rb.AddForce(Camera.main.transform.up * 450);
        rb.AddForce(Camera.main.transform.forward * 450);

        gameObject.GetComponent<IPickup>().Drop();
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        // This should only happen once!
        if (Input.GetKeyDown(KeyCode.G) && transform.parent)
            Throw();
        //{
            //rb.isKinematic = false;
            
            //rb.AddForce(Camera.main.transform.up * 450);
            //rb.AddForce(Camera.main.transform.forward * 450);
            ////rb.AddForce(transform.forward * 450);

            //transform.parent = null;
        //}
        //print("bounce");
    }
}
