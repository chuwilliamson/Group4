using UnityEngine;
using System.Collections;

public class InputHandler : MonoBehaviour {

 
	
	// Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            //walk state
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            //walk state
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            //walk state
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            //walk state
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            PlayerActions.instance.Slap();
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            PlayerActions.instance.Shoot();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            /// Pause State Half (Update at Half speed)
            GameManager.instance.Pause(GameManager.PauseState.Half);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            /// Pause State Full (Update Halted)
            GameManager.instance.Pause(GameManager.PauseState.Full);
        }

        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            /// 
            //GameManager.instance.Transition();
        }
    }
        
    }