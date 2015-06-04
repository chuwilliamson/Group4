using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerActions : MonoBehaviour, IActions
{
    private Vector3 lastFramePosition;

    void Awake()
    {
        fsm = new PlayerFSM();
        lastFramePosition = transform.position;
        _instance = this;
    }
    public void Slap()
    {
<<<<<<< HEAD
        print("slap");
=======
        if (fsm.ActionDict["slap"] == true)
            HUDManager.instance.actionHUD("Slap");
>>>>>>> chuwilliamson/master
    }

    public void Jump()
    {
<<<<<<< HEAD
        print("jump");
=======
        if (fsm.ActionDict["jump"] == true)
            HUDManager.instance.actionHUD("Jump");
>>>>>>> chuwilliamson/master
    }

    public void Shoot()
    {
<<<<<<< HEAD
        print("shoot");
=======
        if (fsm.ActionDict["shoot"] == true)
            HUDManager.instance.actionHUD("Shoot");
>>>>>>> chuwilliamson/master
    }

    public void PlaceTurret()
    {
<<<<<<< HEAD
        print("place turret");
=======
        if (fsm.ActionDict["placeTurret"] == true)
        print("turret placed");
>>>>>>> chuwilliamson/master
    }

    public void State(PlayerState state)
    {        
        //if(gameObject.GetComponent<FirstPersonController>().)
        fsm.ChangeState(state);
    }

    protected static  PlayerActions _instance;
    private PlayerFSM fsm;

    public static PlayerActions instance
    {
        get
        {            
            return _instance;
        }
    }



    void FixedUpdate()
    {
        Vector3 vel = (transform.position - lastFramePosition) / Time.fixedDeltaTime;

        bool idle = Vector3.Distance(transform.position, lastFramePosition) < 0.01;
        lastFramePosition = transform.position;

        bool running = Vector3.Distance(transform.position, lastFramePosition) > 5.00;

        if(idle)
        {
            State(PlayerState.idle);
        }

        if(running)
        {
            State(PlayerState.run);
        }
    }
}
