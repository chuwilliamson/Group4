using UnityEngine;
using System.Collections;

public class FieldOfView : MonoBehaviour 
{
    public bool isTargetInView = false;

    public void OnTriggerStay(Collider c)
    {
<<<<<<< HEAD
=======
<<<<<<< HEAD

>>>>>>> 39207fe6139fa5620cfb47c8e02cd1a3e96b2cf7
        if (c.GetComponent<Stats>())
        if(c.GetComponent<Stats>().isShootable == true)
        isTargetInView = true;
    }

    public void OnTriggerExit(Collider c)
    {
        if (c.GetComponent<Stats>())
<<<<<<< HEAD
=======
            if (c.GetComponent<Stats>().isShootable == true)
                isTargetInView = false;
>>>>>>> Eric/master
    }

    public void OnTriggerExit(Collider c)
    {

        if (c.GetComponent<Stats>())

>>>>>>> 39207fe6139fa5620cfb47c8e02cd1a3e96b2cf7
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
