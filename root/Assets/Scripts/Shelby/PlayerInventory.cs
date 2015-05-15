using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerInventory : MonoBehaviour {

    // resources
    public int scraps,scraps_special;
    public int grenades_reg, grenades_fire, grenades_ice;

    public List<GameObject> items = new List<GameObject>();

    /*
	void Start ()
    {
        scraps = scraps_special = 0;
	}
	*/

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            GameObject gre = Instantiate(items[0]);
            Rigidbody r = gre.GetComponent<Rigidbody>();
            
            r.isKinematic = false;

            r.AddForce(Camera.main.transform.up * 450);
            r.AddForce(Camera.main.transform.forward * 450);
        }
    }
}
