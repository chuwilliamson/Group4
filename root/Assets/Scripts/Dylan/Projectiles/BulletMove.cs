using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour {

    public float mySpeed;
    public float maxDistance;

    private float myDist;

    int numOfShots;

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

        if (gameObject.tag == "ShotGunShell" && isFired == true)
        {
            numOfShots++;

            Vector3 BBPos = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f));

            switch(numOfShots % 6)
            {
                case 1: break;
                case 2: break;
                case 3: break;
                case 4: break;
                case 5: break;
            }
        }
	}
}
