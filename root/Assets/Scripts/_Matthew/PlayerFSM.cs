using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class PlayerFSM
{
    bool canSlap, canJump, canShoot;
    Dictionary<string, bool> ActionDict;
    /// <summary>
    /// on construction we will initialize our action list
    /// </summary>
    public PlayerFSM()
    {
        canSlap = false;
        canJump = false;
        canShoot = false;
        ActionDict = new Dictionary<string, bool>();
        ActionDict.Add("slap", canSlap);
        ActionDict.Add("jump", canJump);
        ActionDict.Add("shoot", canShoot);
        
    }





    /// <summary>
    /// what we want to happen when we are in the current state
    /// </summary>
    /// <param name="state"></param>
    private IEnumerator HandleState(PlayerState state)
    {
        yield return null;
    }

    private void HandleTransition(PlayerState state)
    {

        switch (state)
        {
            case PlayerState.init:
                foreach (KeyValuePair<string, bool> entry in ActionDict)
                {
                    ActionDict[entry.Key] = false;
                }
                break;

            case PlayerState.idle:
                foreach (KeyValuePair<string, bool> entry in ActionDict)
                {
                    ActionDict[entry.Key] = true;
                }
                break;

            case PlayerState.walk:
                foreach (KeyValuePair<string, bool> entry in ActionDict)
                {
                    ActionDict[entry.Key] = true;
                }
                break;

            case PlayerState.run:
                ActionDict["slap"] = false;
                break;
        }

    }

    static PlayerFSM fsm;
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
                    return true;
                break;

            case PlayerState.idle:
                if (to == PlayerState.walk)
                    return true;
                break;

            case PlayerState.walk:
                if (to == PlayerState.run || to == PlayerState.idle)
                    return true;
                break;

            case PlayerState.run:
                if (to == PlayerState.walk)
                    return true;
                break;

            default:
                break;

        }

        return false;
    }


    //lvl1
    //lvl2
    //lvl3



    /// <summary>
    /// called from input handler to change the state of the player
    /// </summary>
    /// <param name="to"></param>
    public void ChangeState(PlayerState to)
    {
        CheckTransition(cState, to);
        HandleTransition(to);
    }

    public void ChangeLevel(string lvl)
    {


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
