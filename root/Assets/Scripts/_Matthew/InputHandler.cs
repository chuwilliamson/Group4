using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class InputHandler : MonoBehaviour 
{
<<<<<<< HEAD
=======
    private GameObject player;
    private GameObject turretManager;
    private GameObject turret;


    //Stores all the keys for each input that should perform an action
    //GameStates
>>>>>>> chuwilliamson/master
    public KeyCode halfPause = KeyCode.C;
    public KeyCode pause = KeyCode.X;
    public KeyCode unpause = KeyCode.Z;
    public KeyCode StartGame = KeyCode.E;

    //player turret selections and placements
    public KeyCode tTurret1 = KeyCode.Alpha1;
    public KeyCode tTurret2 = KeyCode.Alpha2;
    public KeyCode tTurret3 = KeyCode.Alpha3;
    public KeyCode tTurret4 = KeyCode.Alpha4;
    public KeyCode place = KeyCode.Mouse0;

    //player movement controls
    public KeyCode walkForward = KeyCode.W;
    public KeyCode walkBack = KeyCode.S;
    public KeyCode walkLeft = KeyCode.A;
    public KeyCode walkRight = KeyCode.D;
    public KeyCode toggelRun = KeyCode.LeftShift;
    public KeyCode slap = KeyCode.F;
    public KeyCode shoot = KeyCode.V;
    public KeyCode jump = KeyCode.Space;

    //player state change controls
    public KeyCode init = KeyCode.I;
    public KeyCode idle = KeyCode.O;

    //Dev controls
    public KeyCode killTurret = KeyCode.B;

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
<<<<<<< HEAD
        
    }
    void Update()
    {
        TurretPlacement.instance.TurretSelect(tTurret1, tTurret2, tTurret3, tTurret4); // Select Turrets
        TurretPlacement.instance.TurretPlace();
        if (Input.GetKeyDown(slap)) // Slap
        {
            PlayerActions.instance.Slap();
        }

        if (Input.GetKeyDown(shoot)) // Shoot
        {
            PlayerActions.instance.Shoot();
        }
=======
        player = GameObject.FindGameObjectWithTag("Player");
        turretManager = GameObject.FindGameObjectWithTag("TurretManager");

    }
    void Update()
    {
        turret = GameObject.FindGameObjectWithTag("MG");
>>>>>>> chuwilliamson/master

        //Game State changes
        if (Input.GetKeyDown(halfPause))
        {
            /// Pause State Half (Update at Half speed)
            GameManager.instance.Pause(GameManager.PauseState.Half);
        }

        if (Input.GetKeyDown(pause))
        {
<<<<<<< HEAD
            numMultiDel = null;
            num++;
            numMultiDel += NumberPlusFive;
            numMultiDel += NumberSquared;
            numMultiDel(num);

            GameManager.instance.Pause(GameManager.PauseState.Full);
        }

        if (Input.GetKeyDown(unpause))
=======
            GameManager.instance.Pause(GameManager.PauseState.Full);
        }

        if (Input.GetKeyDown(pause))
>>>>>>> chuwilliamson/master
        {
            GameManager.instance.Pause(GameManager.PauseState.None);
        }

<<<<<<< HEAD
        if (Input.GetKeyDown(keyPad))
=======

        ////Player States
        if (Input.GetKeyDown(walkForward)) //Walk forwrad
>>>>>>> chuwilliamson/master
        {
            //GameManager.instance.Transition();
        }

<<<<<<< HEAD
            
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
        
=======
        if (Input.GetKeyDown(walkBack)) //Walk to the back
        {
            player.GetComponent<PlayerActions>().State(PlayerState.walk);
        }

        if (Input.GetKeyDown(walkLeft)) //Walk left
        {
            player.GetComponent<PlayerActions>().State(PlayerState.walk);
        }

        if (Input.GetKeyDown(walkRight)) //Walk to the right
        {
            player.GetComponent<PlayerActions>().State(PlayerState.walk);
        }

        if (Input.GetKeyDown(toggelRun)) //toggles run on
        {
            player.GetComponent<PlayerActions>().State(PlayerState.run);
        }
        if (Input.GetKeyUp(toggelRun)) //toggles run off
        {
            player.GetComponent<PlayerActions>().State(PlayerState.walk);
        }

        if (Input.GetKeyDown(idle)) //toggles idles
        {
            player.GetComponent<PlayerActions>().State(PlayerState.idle);
        }

        if (Input.GetKeyDown(init)) //toggles init
        {
            player.GetComponent<PlayerActions>().State(PlayerState.init);
        }

        ////Player turret Selction and placement
        if (Input.GetKeyDown(tTurret1))
        {
            turretManager.GetComponent<TurretPlacement>().TurretSelect(tTurret1);
        }
        if (Input.GetKeyDown(tTurret2))
        {
            turretManager.GetComponent<TurretPlacement>().TurretSelect(tTurret2);
        }
        if (Input.GetKeyDown(tTurret3))
        {
            turretManager.GetComponent<TurretPlacement>().TurretSelect(tTurret3);
        }
        if (Input.GetKeyDown(tTurret4))
        {
            turretManager.GetComponent<TurretPlacement>().TurretSelect(tTurret4);
        }

        if(Input.GetKeyDown(place))
        {
            turretManager.GetComponent<TurretPlacement>().TurretPlacePoint();
        }

        ////Player Actions
        if (Input.GetKeyDown(slap))
        {
            player.GetComponent<PlayerActions>().Slap();
        }

        if (Input.GetKeyDown(shoot))
        {
            player.GetComponent<PlayerActions>().Shoot();
        }

        if (Input.GetKeyDown(jump))
        {
            player.GetComponent<PlayerActions>().Jump();
        }     


        /////Dev Controls
        if(Input.GetKeyDown(killTurret))
        {
            turret.GetComponent<BaseTurret>().currentHP -= 101;
        }
    }       
>>>>>>> chuwilliamson/master
}