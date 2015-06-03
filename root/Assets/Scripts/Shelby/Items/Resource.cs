using UnityEngine;
using System.Collections;

public class Resource : MonoBehaviour, IPickup {
  
    public int value;

    public void PickUp()
    {
        print("THAT'S A FREAKIN SPECIAL SCRAK");
        Object.Destroy(gameObject);
       
    }

    public void Drop()
    {
        throw new System.NotImplementedException();
    }
}
