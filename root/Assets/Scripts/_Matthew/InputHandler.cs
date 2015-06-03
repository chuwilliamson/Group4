using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class InputHandler : MonoBehaviour 
{
    public KeyCode halfPause = KeyCode.C;
    public KeyCode pause = KeyCode.X;
    public KeyCode unpause = KeyCode.Z;
    public KeyCode slap = KeyCode.F;
    public KeyCode shoot = KeyCode.V;

    public KeyCode tTurret1 = KeyCode.Alpha1;
    public KeyCode tTurret2 = KeyCode.Alpha2;
    public KeyCode tTurret3 = KeyCode.Alpha3;
    public KeyCode tTurret4 = KeyCode.Alpha4;
    public KeyCode keyPad = KeyCode.KeypadEnter;

    //public KeyCode forward = KeyCode.W;
    //public KeyCode left = KeyCode.A;
    //public KeyCode down = KeyCode.S;
    //public KeyCode right = KeyCode.D;
    

	// Update is called once per frame
    delegate void PauseDelegate();
    delegate void NumberDelegate(int n);
    public int num = 0; 

    NumberDelegate numMultiDel;
    
    void Start()
    {
        
    }
    void Update()
    {
        TurretPlacement.instance.TurretSelect(tTurret1, tTurret2, tTurret3, tTurret4); // Input for Turret

        if (Input.GetKeyDown(slap)) // Slap
        {
            PlayerActions.instance.Slap();
        }

        if (Input.GetKeyDown(shoot)) // Shoot
        {
            PlayerActions.instance.Shoot();
        }

        if (Input.GetKeyDown(halfPause))
        {
            /// Pause State Half (Update at Half speed)
            GameManager.instance.Pause(GameManager.PauseState.Half);
        }

        if (Input.GetKeyDown(pause))
        {
            numMultiDel = null;
            num++;
            numMultiDel += NumberPlusFive;
            numMultiDel += NumberSquared;
            numMultiDel(num);

            GameManager.instance.Pause(GameManager.PauseState.Full);
        }

        if(Input.GetKeyDown(pause))
        {
            GameManager.instance.Pause(GameManager.PauseState.None);
        }

        if (Input.GetKeyDown(keyPad))
        {
            //GameManager.instance.Transition();
        }

            
        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    //walk state
        //}

        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    //walk state
        //}

        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //    //walk state
        //}

        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    //walk state
        //}

        
    }


    void NumberSquared(int num)
    {
        print("the number squared: = " + num * num);
        
    }

    void NumberPlusFive(int num)
    {
        print("the number: " + num + "= " + num + 5);
    }
    void doAnotherPause()
    {
        print("doing another pause delegate");
    }

    void doSomethingUnrelatedToPause()
    {
        print("doing something unrelated to pausing");
    }
        
}