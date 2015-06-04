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
        print("slap");
    }

    public void Jump()
    {
        print("jump");
    }

    public void Shoot()
    {
        print("shoot");
    }

    public void PlaceTurret()
    {
        print("place turret");
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
