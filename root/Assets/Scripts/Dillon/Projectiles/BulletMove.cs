using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour {

    public float mySpeed;
    public float maxDistance;

    private float myDist;

    public bool isFired = false; //a bool to check if the bullet is beign fired

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update ()
    {
        if(isFired == true)
        {
            transform.Translate(Vector3.up * Time.deltaTime * mySpeed);
            myDist += Time.deltaTime * mySpeed;

            //moves the bullet across the screen when the turret fires

            if (myDist > maxDistance)
            {
                Destroy(gameObject);
                    //checks to see if the bullet has passed the maximum distance it can travel
                    //and if it dis destroy the object
            }
        }
	}
}
