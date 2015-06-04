using UnityEngine;
using System.Collections;

public class FixExit : MonoBehaviour {

	// Use this for initialization
	void Start () {
        HUDManager.instance.SetState("finish", true);
        HUDManager.instance.SetState("buttons", false);
        print("fix exit");
	
	}
	
}
