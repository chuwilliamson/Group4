using UnityEngine;
using System.Collections;

public class OnCollisionPickUp : MonoBehaviour {

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision other)
    {
        print(other);
        if(other.gameObject.tag =="Item")
        {
            gameObject.GetComponentInChildren<PlayerInventory>().items.Add(gameObject);
            other.gameObject.transform.parent = gameObject.transform;
            other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            other.gameObject.transform.localPosition = new Vector3(0, 1, 2);

            Application.LoadLevel("New");
        }
    }

    void OnCollisionStay(Collision other)
    {
        print(other);
    }
}
