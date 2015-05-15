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
