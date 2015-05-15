using UnityEngine;
using System.Collections;

public class Grenade : MonoBehaviour, IPickup {

    public void Pickup()
    {
        print("picked up grenade");
    }
 
}
