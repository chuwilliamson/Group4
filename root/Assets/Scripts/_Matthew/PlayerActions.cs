using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerActions : MonoBehaviour, IActions
{
    string action;
    private Vector3 lastFramePosition;

    void Awake()
    {
        fsm = new PlayerFSM();
        lastFramePosition = transform.position;
        _instance = this;
    }
    public void Slap()
    {

        print("slap");

        if (fsm.ActionDict["slap"] == true)
            action = "slap";

    }

    public void Jump()
    {

        print("jump");

        if (fsm.ActionDict["jump"] == true)
            action = "jump";
    }

    public void Shoot()
    {

        print("shoot");

        if (fsm.ActionDict["shoot"] == true)
            action = "shoot";
    }

    public void PlaceTurret()
    {

        print("place turret");

        if (fsm.ActionDict["placeTurret"] == true)
        print("turret placed");

    }

    public void State(PlayerState state)
    {        
        fsm.ChangeState(state);
    }

    void Update()
    {
        HUDManager.instance.SetInfoLeft(fsm.CurrentState.ToString() + "\n" + action);
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
