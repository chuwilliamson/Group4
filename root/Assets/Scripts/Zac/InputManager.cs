using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {
 
	
	// Update is called once per frame
	void Update () 
    {
        bool buttonpress = false;
        if (buttonpress)
            GameManager.instance.Transition(GameManager.Level.MainMenu);
	}
}
