using UnityEngine;
using System.Collections;

public class FieldOfView : MonoBehaviour 
{
    public bool isTargetInView = false;

    public void OnTriggerStay(Collider c)
    {
<<<<<<< HEAD
=======
        if (c.GetComponent<Stats>())
>>>>>>> Quinton/master
        if(c.GetComponent<Stats>().isShootable == true)
        isTargetInView = true;
    }

    public void OnTriggerExit(Collider c)
    {
<<<<<<< HEAD
=======
        if (c.GetComponent<Stats>())
>>>>>>> Quinton/master
        if (c.GetComponent<Stats>().isShootable == true)
            isTargetInView = false;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
