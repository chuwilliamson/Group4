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
            HUDManager.instance.actionHUD("Slap");
    }

    public void Jump()
    {
        if (fsm.ActionDict["jump"] == true)
            HUDManager.instance.actionHUD("Jump");
    }

    public void Shoot()
    {
        if (fsm.ActionDict["shoot"] == true)
            HUDManager.instance.actionHUD("Shoot");
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
