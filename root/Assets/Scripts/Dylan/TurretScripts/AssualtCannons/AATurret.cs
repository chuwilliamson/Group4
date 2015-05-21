using UnityEngine;
using System.Collections;

public class AATurret : MonoBehaviour 
{
    int looper = 5;
    Transform[] barrels;

    void AlternatingBarrelFire()
    {
        foreach (Transform barrel in barrels)
        {
            Instantiate(GetComponent<BaseTurret>().bullet, barrel.position, barrel.rotation);
            print("Shoot");
        }
    }

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {

	}
}
