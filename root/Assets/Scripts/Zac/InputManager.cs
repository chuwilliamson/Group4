using UnityEngine;
using System.Collections.Generic;

public class InputManager : MonoBehaviour {

    //private enum InputType
    //{
    //    MoveForward,
    //    MoveBackward,
    //    MoveLeft,
    //    MoveRight,
    //    TurnRight,
    //    TurnLeft,
    //    Jump,
    //    Interact,
    //    Count
    //};
    //public string[] PlayerInput = new string[(int)InputType.Count];
    
    //public Dictionary<string,string> = {};
    

	// Update is called once per frame
	void Update () 
    {
        int pn = 1;
        Input.GetAxis("Horizontal" + pn); // if pn = 1




        if(Input.GetButton("Fire1"))
        {

        }
        bool buttonpress = false;
        if (buttonpress)
            GameManager.instance.Transition(GameManager.Level.MainMenu);
	}
}
