using UnityEngine;
using System.Collections;

public class PlayerActions : MonoBehaviour, IActions
{ 
    void Awake()
    {
        fsm = new PlayerFSM();
        _instance = this;
    }
    public void Slap()
    {
        if (fsm.ActionDict["slap"] == true)
        print("slap");
    }

    public void Jump()
    {
        if (fsm.ActionDict["jump"] == true)
        print("jump");
    }

    public void Shoot()
    {
        if (fsm.ActionDict["shoot"] == true)
        print("shoot");
    }

    public void PlaceTurret()
    {
        if (fsm.ActionDict["placeTurret"] == true)
        print("turret placed");
    }



    public void State(PlayerState state)
    {
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



}
