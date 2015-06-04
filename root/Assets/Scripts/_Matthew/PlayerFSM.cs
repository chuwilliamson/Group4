using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class PlayerFSM
{
    bool canSlap, canJump, canShoot, placeTurret;
    public Dictionary<string, bool> ActionDict;
    /// <summary>
    /// on construction we will initialize our action list
    /// </summary>
    public PlayerFSM()
    {
        canSlap = false;
        canJump = false;
        canShoot = false;
        placeTurret = false;

        ActionDict = new Dictionary<string, bool>();
        ActionDict.Add("slap", canSlap);
        ActionDict.Add("jump", canJump);
        ActionDict.Add("shoot", canShoot);
        ActionDict.Add("placeTurret", placeTurret);
    }

    /// <summary>
    /// what we want to happen when we are in the current state
    /// </summary>
    /// <param name="state"></param>

    private void HandleTransition(PlayerState state)
    {
        switch (state)
        {
            case PlayerState.init: //start up
                foreach (KeyValuePair<string, bool> entry in ActionDict)
                {
                    ActionDict[entry.Key] = false; //cant do anything in the dictionary
                }
                break;

            case PlayerState.idle:
                foreach (KeyValuePair<string, bool> entry in ActionDict)
                {
                    ActionDict[entry.Key] = true; //can do everything in the dictionary
                }
                break;

            case PlayerState.walk:
                foreach (KeyValuePair<string, bool> entry in ActionDict)
                {
                    ActionDict[entry.Key] = true; //can do everything in the dictionary
                }
                break;

            case PlayerState.run:
                ActionDict["slap"] = false; //cant slap but can do everyting else in the dictionary
                break;
        }
    }

    protected static PlayerFSM _fsm;
    /// <summary>
    /// validate a transition from one state to another state
    /// </summary>
    /// <param name="from">
    /// our current state 
    /// </param>
    /// <param name="to">
    /// the state we are transitioning to
    /// </param>
    /// <returns>
    /// whether or not we have a valid transition
    /// </returns>
    private bool CheckTransition(PlayerState from, PlayerState to)
    {
        switch (from)
        {
            case PlayerState.init:
                if (to == PlayerState.idle)
                {
<<<<<<< HEAD
                    Debug.Log(to);
=======
                    cState = to;
                    HUDManager.instance.stateHUD(cState);
>>>>>>> chuwilliamson/master
                    return true;
                }
                break;

            case PlayerState.idle:
                if (to == PlayerState.walk)
                {
<<<<<<< HEAD
                    Debug.Log(to);
=======
                    cState = to;
                    HUDManager.instance.stateHUD(cState);
>>>>>>> chuwilliamson/master
                    return true;
                }
                break;

            case PlayerState.walk:
                if (to == PlayerState.run || to == PlayerState.idle)
                {
<<<<<<< HEAD
                    Debug.Log(to);
=======
                    cState = to;
                    HUDManager.instance.stateHUD(cState);
>>>>>>> chuwilliamson/master
                    return true;
                }
                break;

            case PlayerState.run:
                if (to == PlayerState.walk)
                {
<<<<<<< HEAD
                    Debug.Log(to);
=======
                    cState = to;
                    HUDManager.instance.stateHUD(cState);
>>>>>>> chuwilliamson/master
                    return true;
                }
                break;

            default:
                break;

        }
        return false;
    }


    /// <summary>
    /// called from input handler to change the state of the player
    /// </summary>
    /// <param name="to"></param>
    public void ChangeState(PlayerState to)
    {
        CheckTransition(cState, to);
        HandleTransition(to);
    }

    private PlayerState cState;

    public PlayerState CurrentState
    {
        get
        {
            return cState;
        }
    }
}
