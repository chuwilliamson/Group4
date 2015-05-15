using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour {

    public float mySpeed;
    public float myRange;

    private float myDist;

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Vector3.up * Time.deltaTime * mySpeed);
        myDist += Time.deltaTime * mySpeed;

        if (myDist > myRange)
            Destroy(gameObject);
	}
}
