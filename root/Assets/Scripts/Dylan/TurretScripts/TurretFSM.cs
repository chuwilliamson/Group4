﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TurretFSM
{

    bool isReloading;

    bool t_IsReloading;


    public Dictionary<string, bool> TurretActions;

    public TurretFSM()
    {

        isReloading = false;

        TurretActions = new Dictionary<string, bool>();
        TurretActions.Add("Reload", isReloading);
    }

    private void HandleTransition(TurretState state)
    {
        foreach(string Key in new List<string>(TurretActions.Keys))

        t_IsReloading = false;

        TurretActions = new Dictionary<string, bool>();
        TurretActions.Add("Reload", t_IsReloading);
    }

    private void t_HandleTransition(TurretState state)
    {
        foreach (string Key in new List<string>(TurretActions.Keys))

        {
            switch (state)
            {
                case TurretState.idle:
                    TurretActions[Key] = true;
                    break;
                case TurretState.patrol:
                    TurretActions[Key] = false;
                    break;
                case TurretState.shoot:
                    TurretActions[Key] = false;
                    break;
                case TurretState.destroyed:
                    TurretActions[Key] = false;
                    break;
            }
        }
    }

    protected static TurretFSM _fsm;


    private bool checkTransition(TurretState from, TurretState to)
    {
        switch(from)

    private bool t_CheckTransition(TurretState from, TurretState to)
    {
        switch (from)

        {
            case TurretState.idle:
                if (to == TurretState.patrol || to == TurretState.patrol)
                {

                    cState = to;
                    return true;
                }
                break;
                
            case TurretState.patrol:
                if (to == TurretState.shoot || to == TurretState.patrol || to == TurretState.idle)
                {
                    cState = to;

                    t_cState = to;
                    return true;
                }
                break;

            case TurretState.patrol:
                if (to == TurretState.shoot || to == TurretState.patrol || to == TurretState.idle)
                {
                    t_cState = to;

                    return true;
                }
                break;

            case TurretState.shoot:

                if(to == TurretState.destroyed || to == TurretState.patrol)
                {
                    cState = to;

                if (to == TurretState.destroyed || to == TurretState.patrol)
                {
                    t_cState = to;

                    return true;
                }
                break;

            default:
                break;
        }
        return false;
    }


    public void ChangeState(TurretState to)
    {
        checkTransition(cState, to);
    }

    private TurretState cState = TurretState.idle;

    public TurretState CurrentState
    {
        get
        {
            return cState;
        }
    }
}

    public void t_ChangeState(TurretState to)
    {
        t_CheckTransition(t_cState, to);
    }

    private TurretState t_cState = TurretState.idle;

    public TurretState t_CurrentState
    {
        get
        {
            return t_cState;
        }
    }
}

